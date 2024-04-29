using FoodToOrder_Database;
using FoodToOrder_WPF.controls;
using MaterialDesignThemes.Wpf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for Dishes.xaml
    /// </summary>
    public partial class Dishes : Window
    {
        private List<Dish> dishList = new List<Dish>();
        public List<Dish> DishList { get { return dishList; } set { dishList = value; } }

        public Dictionary<int, int> Orders = new Dictionary<int, int>();
        public int currentRestaurantID { get; set; }
        public string currentRestaurantName { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }
        
        public Dishes()
        {
            //InitializeComponent();
            DataContext = this;
        }

        public Dishes(int id, string RestaurantName)
        {
            InitializeComponent();
            this.currentRestaurantID = id;
            this.currentRestaurantName = RestaurantName;
            DataContext = this;
            populateDishes();
        }

        private void populateDishes()
        {
            string connectionString = "Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT d.* FROM [dbo].[Dish] d JOIN [dbo].[Restaurant] r ON d.RestaurantId = r.Id WHERE d.Available='true'" + "AND r.Id = " + currentRestaurantID , connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int flag = 1;

                    DishesHeading.Text = currentRestaurantName + " - DISHES";

                    while (reader.Read())
                    {
                        string dishName = reader["DishName"].ToString();
                        decimal price = Decimal.Parse(reader["Price"].ToString());
                        bool isAvailable = (bool)reader["Available"];
                        int id = Int32.Parse(reader["id"].ToString());

                        Dish currentDish = new();
                        currentDish.Id = id;
                        currentDish.DishName = dishName;
                        currentDish.Price = price;
                        currentDish.Available = isAvailable;
                        currentDish.RestaurantId = currentRestaurantID;

                        DishList.Add(currentDish);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Place_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            decimal total = 0;

            foreach (var item in dishListBox.Items)
            {
                ListBoxItem listBoxItem = dishListBox.ItemContainerGenerator.ContainerFromItem(item) as ListBoxItem;

                // Find the CounterControl within the ListBoxItem
                CounterControl counterControl = FindChild<CounterControl>(listBoxItem, "DishQty");

                if (counterControl != null)
                {
                    int quantity = counterControl.Counter;
                    decimal price = (item as Dish).Price;
                    int orderedDishId = (item as Dish).Id;
                    decimal itemTotal = quantity * price;
                    Orders.Add(orderedDishId, quantity);
                    total += itemTotal;
                }
            }


            PlaceOrder placeorder = new PlaceOrder(Orders, total);
            placeorder.Show();
            Close();
        }

        private T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            if (parent == null)
                return null;

            T foundChild = null;
            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                // If the child is of the requested type and has the specified name, return it
                if (child is T typedChild && (child as FrameworkElement)?.Name == childName)
                {
                    foundChild = typedChild;
                    break;
                }

                // Search child's children recursively
                foundChild = FindChild<T>(child, childName);

                if (foundChild != null)
                    break;
            }

            return foundChild;
        }
    }
}
