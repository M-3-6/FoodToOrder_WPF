using Microsoft.Data.SqlClient;
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
    /// Interaction logic for DeleteDish.xaml
    /// </summary>
    public partial class DeleteDish : Window
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public DeleteDish()
        {
            
        }
        public DeleteDish(int id, string name)
        {
            
            this.Id = id;
            this.DishName = name;
            InitializeComponent();
            RemoveDish();
        }

        private void RemoveDish()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");
                con.Open();
                SqlCommand cmd;

                cmd = new SqlCommand("Delete from [dbo].[Dish] where Id=" + Id, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Dish: " + DishName + "!");

                con.Close();
                //this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
