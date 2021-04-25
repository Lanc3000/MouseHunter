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

namespace MouseHunter
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(this);
            MessageBox.Show($"x = {point.X.ToString()}, y = {point.Y.ToString()}");
        }
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            Point point = Mouse.GetPosition(displayArea);
            coordinateTb.Text = "X: " + point.X + ", Y: " + point.Y;
        }
    }
}
