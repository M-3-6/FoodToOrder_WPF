using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodToOrder_WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 
    public class EmailValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string email = value as string;

            if (string.IsNullOrWhiteSpace(email))
            {
                return new ValidationResult(false, "Email address is required.");
            }

            if (!Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
            {
                return new ValidationResult(false, "Invalid email address format.");
            }

            return ValidationResult.ValidResult;
        }
    }
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        Register registerScreen = new Register();
        Restaurants restaurantsScreen = new Restaurants();
        RestaurantsHome adminHome = new RestaurantsHome();

        private void Register_Link_Clicked(object sender, RoutedEventArgs e)
        {
            registerScreen.Show();
            Close();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {

            if (LEmail.Text.Length == 0)
            {
                LerrorMessage.Text = "Please enter your email!";
                LEmail.Focus();
                LEmail.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                LEmail.BorderThickness = new Thickness(1);
            }
            else if (LPassword.Password.Length == 0)
            {
                LerrorMessage.Text = "Please enter your password!";
                LPassword.Focus();
                LPassword.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                LPassword.BorderThickness = new Thickness(1);
            }
            else if (!Regex.IsMatch(LEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                LerrorMessage.Text = "Enter a valid email.";
                LEmail.Select(0, LEmail.Text.Length);
                LEmail.Focus();
            }
            else
            {
                try
                {
                    string email = LEmail.Text;
                    string password = LPassword.Password;
                    SqlConnection con = new SqlConnection("Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Maria;User=sa;Password=sa@1234;TrustServerCertificate=True;MultipleActiveResultSets=True;");

                    con.Open();
                    SqlCommand cmd;

                    cmd = new SqlCommand("Select * from [dbo].[User] where Email='" + email + "'  and Password='" + password + "'", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        string role = dataSet.Tables[0].Rows[0]["Role"].ToString();

                        if (role == "Admin") adminHome.Show();
                        else restaurantsScreen.Show();
                        Close();
                    }
                    else
                    {
                        LerrorMessage.Text = "Please enter existing emailid/password!";
                    }

                    con.Close();
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }

        }

    }
}