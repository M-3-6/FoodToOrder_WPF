using FoodToOrder_Database;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using UserControl = System.Windows.Controls.UserControl;

namespace FoodToOrder_WPF.controls
{
    /// <summary>
    /// Interaction logic for RestaurantControl.xaml
    /// </summary>
    public partial class RestaurantControl : UserControl
    {
        public RestaurantControl()
        {
            InitializeComponent();
        }

        private void btnEditRestaurant_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Restaurant restaurant)
            {
                EditRestaurant er = new EditRestaurant(restaurant.Id);
                er.Show();
            }
        }

        private void btnDeleteRestaurant_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Restaurant restaurant)
            {
                DeleteRestaurant dr = new DeleteRestaurant(restaurant.Id, restaurant.RestaurantName);                      
            }
        }
    }
}
