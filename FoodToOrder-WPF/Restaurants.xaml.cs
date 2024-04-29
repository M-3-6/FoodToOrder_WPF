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
using FoodToOrder_Database;
using Microsoft.Data.SqlClient;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for Restaurants.xaml
    /// </summary>
    public partial class Restaurants : Window
    {
        public Restaurants()
        {
            InitializeComponent();
            PopulateRestaurants();
            //FoodToOrderWpfMariaContext cxt = new FoodToOrderWpfMariaContext();
            //List<Restaurant> restaurantsList = cxt.Restaurants.ToList<Restaurant>();
            //List<string> restaurantNames = cxt.Restaurants.Select(r => r.RestaurantName).ToList();
            //restaurants.ItemsSource = restaurantNames;
            
        }

        private void PopulateRestaurants()
        {
            string connectionString = "Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Restaurant] WHERE ROpen='true'", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string restaurantName = reader["RestaurantName"].ToString();
                        int RId = Int32.Parse(reader["Id"].ToString());

                        StackPanel stackPanel = new StackPanel();
                        stackPanel.Orientation = Orientation.Horizontal;

                        Label lbl = new Label();
                        lbl.Content = restaurantName;
                        lbl.Width = 100;

                        Button detailsButton = new Button();
                        detailsButton.Content = "View Details";
                        detailsButton.Foreground = new SolidColorBrush(Color.FromRgb(255,255,255));
                        detailsButton.FontSize = 12;

                        // delegate to handle click event
                        detailsButton.Click += (sender, e) =>
                        {
                            Dishes dishes = new Dishes(RId, restaurantName);
                            dishes.Show();
                            Close();
                        };

                        stackPanel.Children.Add(lbl);
                        stackPanel.Children.Add(detailsButton);
                       
                        restaurants.Items.Add(stackPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

            private void Restaurant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            foreach(ListBoxItem li in restaurants.SelectedItems)
            {
                //StackPanel sp = (StackPanel)li.Content;
                //Label lbl = (Label)sp.Children[0];
                //MessageBox.Show(lbl.Content.ToString() + " is clicked!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
