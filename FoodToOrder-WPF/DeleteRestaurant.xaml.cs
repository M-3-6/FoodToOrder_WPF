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
    /// Interaction logic for DeleteRestaurant.xaml
    /// </summary>
    public partial class DeleteRestaurant : Window
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public DeleteRestaurant()
        {
            
        }

        public DeleteRestaurant(int id, string RestaurantName)
        {
            this.Id = id;
            this.RestaurantName = RestaurantName;
            InitializeComponent();
            RemoveRestaurant();
        }

        private void RemoveRestaurant()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");
                con.Open();
                SqlCommand cmd;

                cmd = new SqlCommand("Delete from [dbo].[Restaurant] where Id=" + Id, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Restaurant: " + RestaurantName + "!" );

                con.Close();
                //this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
        }

    }
}
