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
    /// Interaction logic for EditDish.xaml
    /// </summary>
    public partial class EditDish : Window
    {
        public int DishId {  get; set; }
        public string DName {  get; set; }
        public EditDish()
        {
            
        }

        public EditDish(int dishId, string dName)
        {
            DishId = dishId;
            DName = dName;
            InitializeComponent();
        }

        private void SubmitEditDishBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dishName = editDishNameLabel.Text.ToString();
                decimal price = Decimal.Parse(editDishPriceLabel.Text.ToString());
                bool isAvailable = (bool)editDishAvlStatus.IsChecked;
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Dish] SET DishName='" + dishName + "', Price = '" + price +"', Available = '" + isAvailable + "'  WHERE Id=" + this.DishId, con);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edited Dish " + DName + " !");
                con.Close();
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
