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
    /// Interaction logic for RestaurantsAdmin.xaml
    /// </summary>
    public partial class RestaurantsAdmin : Window
    {
        private List<Restaurant> restaurants = new List<Restaurant>();
        public List<Restaurant> Restaurants { get { return restaurants;  } set { restaurants = value; } }
        public RestaurantsAdmin()
        {
            InitializeComponent();
            DataContext = this;
            PopulateRestaurants();
        }

        private void Restaurant_Modify_Done_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateRestaurants()
        {
            string connectionString = "Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Restaurant]", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string restaurantName = reader["RestaurantName"].ToString();
                        int RId = Int32.Parse(reader["Id"].ToString());
                        bool open = (bool)reader["ROpen"];
                        int UId = Int32.Parse(reader["UserId"].ToString());

                        Restaurant r = new();
                        r.Id = RId;
                        r.RestaurantName = restaurantName;
                        r.Ropen = open;
                        r.UserId = UId;
                        Restaurants.Add(r);
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