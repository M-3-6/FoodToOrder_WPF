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
    /// Interaction logic for RestaurantsHome.xaml
    /// </summary>
    public partial class RestaurantsHome : Window
    {
        public RestaurantsHome()
        {
            InitializeComponent();
        }

        private void Add_Restaurant_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            AddRestaurant ar = new AddRestaurant();
            ar.Show();
        }

        private void View_Restaurant_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            ViewRestaurants vr = new ViewRestaurants();
            vr.Show();
        }

        private void Modify_Restaurant_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            RestaurantsAdmin restaurantsAdminScreen = new RestaurantsAdmin();
            restaurantsAdminScreen.Show();
        }
    }
}
