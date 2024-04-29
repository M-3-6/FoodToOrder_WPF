using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for AddRestaurant.xaml
    /// </summary>
    public partial class AddRestaurant : Window
    {
        public int RestaurantID {  get; set; }
        public AddRestaurant()
        {
            InitializeComponent();
            this.RestaurantID = new IDGenerator().GenerateId();
        }

        private void SubmitAddRestaurantBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string restaurantName = restaurantNameLabel.Text.ToString();
                bool isOpen = (bool) restaurantOpenStatus.IsChecked;
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Restaurant] (Id, RestaurantName, ROpen, UserId) VALUES (@Id, @RestaurantName, @ROpen, @UserId)", con);
                cmd.Parameters.AddWithValue("@Id", this.RestaurantID);
                cmd.Parameters.AddWithValue("@RestaurantName", restaurantName);
                cmd.Parameters.AddWithValue("@ROpen", isOpen);
                cmd.Parameters.AddWithValue("@UserId", 5);           

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Restaurant " + restaurantName + " !");
                con.Close();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddDishButton_Clicked(object sender, RoutedEventArgs e)
        {
            AddDish ad = new AddDish(this.RestaurantID);
            ad.Show();

        }

    }
}
