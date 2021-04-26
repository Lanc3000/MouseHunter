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

namespace MouseHunter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client service = new ServiceReference.Service1Client();
            try
            {
                if (service.Authorization(LoginBox.Text, PasswordBox.Password)) 
                {
                    ClientWindow clientWindow = new ClientWindow();
                    clientWindow.Show();
                    this.Close();
                }
                else
                {
                    LoginMessageBlock.Text = "Неверный пароль или логин!";
                    LoginMessageBlock.Visibility = Visibility.Visible;
                }
            }
            catch (Exception) { } 
        }

    }
}
