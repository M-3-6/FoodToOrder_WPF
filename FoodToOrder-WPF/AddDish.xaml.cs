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

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for AddDish.xaml
    /// </summary>
    public partial class AddDish : Window
    {
        public int RestaurantId { get; set; }
        public int DishId { get; set; }
        public AddDish()
        {           
        }
        public AddDish(int id)
        {
            this.RestaurantId = id;
            InitializeComponent();
            this.DishId = new IDGenerator().GenerateId();
        }

        private void SubmitAddDishBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dishName = dishNameLabel.Text.ToString();
                bool isAvl = (bool)dishAvlStatus.IsChecked;
                decimal price = Decimal.Parse(dishPriceLabel.Text.ToString());
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Dish] (Id, DishName, Available, Price, RestaurantId) VALUES (@Id, @DishName, @Available, @Price, @RestaurantId)", con);
                cmd.Parameters.AddWithValue("@Id", this.DishId);
                cmd.Parameters.AddWithValue("@DishName", dishName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Available", isAvl);
                cmd.Parameters.AddWithValue("@RestaurantId", this.RestaurantId);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Dish " + dishName + " !");
                con.Close();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
