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
    /// Interaction logic for PlaceOrder.xaml
    /// </summary>
    public partial class PlaceOrder : Window
    {
        public Dictionary<int, int> Orders = new Dictionary<int, int>();
        public decimal Total = 0;

        public PlaceOrder() { }
        public PlaceOrder(Dictionary<int,int> Orders, decimal Total)
        {
            InitializeComponent();
            this.Orders = Orders;
            this.Total = Total;
            displayBill();
        }

        public void displayBill()
        {
            StackPanel stackPanel = new StackPanel();
            try
            {
                foreach (var item in this.Orders)
                {
                    int id = item.Key;
                    int qty = item.Value;
                
                    SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                    con.Open();
                    SqlCommand cmd;

                    cmd = new SqlCommand("Select DishName, Price from [dbo].[Dish] where id=" + id, con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0 && qty > 0)
                    {
                        string dishName = dataSet.Tables[0].Rows[0]["DishName"].ToString();
                        decimal dishPrice = (decimal)dataSet.Tables[0].Rows[0]["Price"];
                       
                        TextBlock tDish = new TextBlock();
                        TextBlock tPrice = new TextBlock();
                        TextBlock tQuantity = new TextBlock();

                        tDish.Text = dishName;
                        tPrice.Text = "Rs." + dishPrice.ToString();
                        tQuantity.Text = qty.ToString();

                        stackPanel.Orientation = Orientation.Vertical;
                        stackPanel.Children.Add(tDish);
                        stackPanel.Children.Add(tPrice);
                        stackPanel.Children.Add(tQuantity);

                    }
                    
                    con.Close();
                }

                TextBlock total = new TextBlock();
                total.Text = "Total Bill : Rs." + this.Total.ToString();
                
                stackPanel.Children.Add(total);
                billListBox.Items.Add(stackPanel);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
