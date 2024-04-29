using FoodToOrder_Database;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ViewDish.xaml
    /// </summary>
    public partial class ViewDish : Window
    {
        public int RestaurantId { get; set; }
        public ViewDish()
        {
            
        }
        public ViewDish(int restaurantId)
        {
            this.RestaurantId = restaurantId;
            InitializeComponent();
            FoodToOrderWpfMariaContext cxt = new FoodToOrderWpfMariaContext();
            //List<Restaurant> restaurantsList = cxt.Restaurants.ToList<Restaurant>();
            List<string> dishNames = cxt.Dishes.Where(d => d.RestaurantId == restaurantId).Select(d => d.DishName).ToList();
            List<decimal> dishPrices = cxt.Dishes.Where(d => d.RestaurantId == restaurantId).Select(d => d.Price).ToList();
            List<int> dishIds = cxt.Dishes.Where(d => d.RestaurantId == restaurantId).Select(d => d.Id).ToList();
            DishesList.ItemsSource = dishNames;
            DishesPriceList.ItemsSource = dishPrices;
            List<Image> dishImgList = [];
            for (int i = 0; i < dishIds.Count; i++)
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("pack://application:,,,/images/" + dishIds[i].ToString().Trim() +".jpg");
                img.EndInit();

                Image imageControl = new Image();
                imageControl.Source = img;
                imageControl.Width = 30;
                imageControl.Height = 30;
                
                dishImgList.Add(imageControl);
            }
            DishImages.ItemsSource = dishImgList;
        }
    }
}
