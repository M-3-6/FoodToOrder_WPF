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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodToOrder_WPF.controls
{
    /// <summary>
    /// Interaction logic for DishControl.xaml
    /// </summary>
    public partial class DishControl : UserControl
    {
        public DishControl()
        {
            InitializeComponent();
            
        }

        public static readonly DependencyProperty DishProperty = DependencyProperty.Register("Dish",typeof(Dish),typeof(DishControl));

        public Dish Dish
        {
            get { return (Dish)GetValue(DishProperty); }
            set { SetValue(DishProperty, value); }
        }

        private void btnEditDish_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Dish dish)
            {
                EditDish ed = new EditDish(dish.Id, dish.DishName);
                ed.Show();
            }
        }

        private void btnDeleteDish_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Dish dish)
            {
                DeleteDish d = new DeleteDish(dish.Id, dish.DishName);
            }
        }
    }
}
