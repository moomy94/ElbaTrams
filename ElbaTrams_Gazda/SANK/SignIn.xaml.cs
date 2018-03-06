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

namespace SANK
{
    /// <summary>
    /// Interaction logic for SignIN.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        string username;
        string password;
        string user = "user";
        string pass = "pass";
        public SignIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            password = PassBox.Password;
            username = UserBox.Text;
            bool jednako = String.Equals(password, pass, StringComparison.OrdinalIgnoreCase);
            bool jednako2 = String.Equals(username, user, StringComparison.OrdinalIgnoreCase);
            if (jednako&&jednako2)
            {
                SignedIn.Visibility=Visibility.Visible;
                Application.Current.MainWindow.Show();
                this.Hide();
            }
            else
            {
                Wrong.Visibility = Visibility.Visible;
                PassBox.Password = "";
                UserBox.Text = "";
            }
                
        }

        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Return)
            {
                password = PassBox.Password;
                username = UserBox.Text;
                bool jednako = String.Equals(password, pass, StringComparison.OrdinalIgnoreCase);
                bool jednako2 = String.Equals(username, user, StringComparison.OrdinalIgnoreCase);
                if (jednako && jednako2)
                {
                    SignedIn.Visibility = Visibility.Visible;
                    Application.Current.MainWindow.Show();
                    this.Hide();
                }
                else
                {
                    Wrong.Visibility = Visibility.Visible;
                    PassBox.Password = "";
                    UserBox.Text = "";
                }

            }
        }

       
    }
}
