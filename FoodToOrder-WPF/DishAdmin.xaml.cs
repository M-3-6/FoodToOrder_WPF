using FoodToOrder_Database;
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
using System.Windows.Shapes;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for DishAdmin.xaml
    /// </summary>
    public partial class DishAdmin : Window
    {
        public int RestaurantId { get; set; }
        private List<Dish> dishes = new List<Dish>();
        public List<Dish> Dishes { get { return dishes; } set { dishes = value; } }

        public DishAdmin()
        {
        }

        public DishAdmin(int restaurantId)
        {
            
            RestaurantId = restaurantId;
            InitializeComponent();
            DataContext = this;
            populateDishes();

        }

        private void Modify_Done_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateDishes()
        {
            string connectionString = "Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Dish] WHERE RestaurantId = " + RestaurantId, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string dishName = reader["DishName"].ToString();
                        int DId = Int32.Parse(reader["Id"].ToString());
                        bool available = (bool)reader["Available"];
                        decimal price = Decimal.Parse(reader["Price"].ToString());
                        int RId = Int32.Parse(reader["RestaurantId"].ToString());

                        Dish d = new();
                        d.Id = DId;
                        d.DishName = dishName;
                        d.Available = available;
                        d.Price = price;
                        d.RestaurantId = RId;
                        Dishes.Add(d);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
