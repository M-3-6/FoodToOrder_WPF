using FoodToOrder_Database;
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
    /// Interaction logic for ViewRestaurants.xaml
    /// </summary>
    public partial class ViewRestaurants : Window
    {
        public ViewRestaurants()
        {
            InitializeComponent();
            FoodToOrderWpfMariaContext cxt = new FoodToOrderWpfMariaContext();
            //List<Restaurant> restaurantsList = cxt.Restaurants.ToList<Restaurant>();
            List<string> restaurantNames = cxt.Restaurants.Select(r => r.RestaurantName).ToList();
            RestaurantsList.ItemsSource = restaurantNames;
        }
    }
}
