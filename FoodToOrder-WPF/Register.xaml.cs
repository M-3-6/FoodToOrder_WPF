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
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        Restaurants restaurantsScreen = new Restaurants();

        private void Login_Link_Clicked(object sender, RoutedEventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
            Close();
        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            if (RFirstName.Text.Length == 0)
            {
                RerrorMessage.Text = "Please enter your first name!";
                RFirstName.Focus();
                RFirstName.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                RFirstName.BorderThickness = new Thickness(1);
            }
            if (RLastName.Text.Length == 0)
            {
                RerrorMessage.Text = "Please enter your last name!";
                RLastName.Focus();
                RLastName.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                RLastName.BorderThickness = new Thickness(1);
            }
            if (REmail.Text.Length == 0)
            {
                RerrorMessage.Text = "Please enter your email!";
                REmail.Focus();
                REmail.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                REmail.BorderThickness = new Thickness(1);
            }
            else if (RPassword.Password.Length == 0)
            {
                RerrorMessage.Text = "Please enter your password!";
                RPassword.Focus();
                RPassword.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                RPassword.BorderThickness = new Thickness(1);
            }
            else if (!RPassword.Password.Equals(RepeatPassword.Password))
            {
                RerrorMessage.Text = "Passwords do not match!";
                RepeatPassword.Focus();
                RepeatPassword.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                RepeatPassword.BorderThickness = new Thickness(1);
            }
            else
            {
                string firstName = RFirstName.Text;
                string lastName = RLastName.Text;
                string email = REmail.Text;
                string password = RPassword.Password;
                SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User] (id, firstname, lastname, email, password, role) VALUES (@Id, @FirstName, @LastName, @Email, @Password, @Role)", con);
                cmd.Parameters.AddWithValue("@Id", new IDGenerator().GenerateId());
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", "Customer");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                restaurantsScreen.Show();
                Close();
                con.Close();
            }
        }

    }
}
