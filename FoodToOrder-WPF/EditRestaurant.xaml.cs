using FoodToOrder_Database;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for EditRestaurant.xaml
    /// </summary>
    public partial class EditRestaurant : Window
    {
        public int RestaurantId {  get; set; }
        public EditRestaurant()
        {
        }
        public EditRestaurant(int restaurantId)
        {
            InitializeComponent();
            this.RestaurantId = restaurantId;
        }

        private void SubmitEditRestaurantBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string restaurantName = editRestaurantNameLabel.Text.ToString();
                bool isOpen = (bool)editRestaurantOpenStatus.IsChecked;
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Restaurant] SET RestaurantName='" + restaurantName + "', ROpen='" + isOpen + "'  WHERE Id=" + this.RestaurantId, con);               

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edited Restaurant " + restaurantName + " !");
                con.Close();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddDishButton_Clicked(object sender, RoutedEventArgs e)
        {
            AddDish ad = new AddDish(this.RestaurantId);
            ad.Show();
        }

        private void EditDishButton_Clicked(object sender, RoutedEventArgs e)
        {
            DishAdmin da = new DishAdmin(RestaurantId);
            da.Show();
        }

        private void ViewDishButton_Clicked(object sender, RoutedEventArgs e)
        {
            ViewDish d = new ViewDish(this.RestaurantId);
            d.Show();
        }
    }
}
