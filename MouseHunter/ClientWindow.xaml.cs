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
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(this);
            Point locationBtn = startBtn.PointToScreen(new Point(0, 0)); // зададим начальные координаты для отчета смещения мыши
            double startX = locationBtn.X;
            double startY = locationBtn.Y;
            double x = point.X;
            double y = point.Y;
            if (Math.Abs(startX - x) > 100 || Math.Abs(startY - y) > 100)
            {
                coordinateTb.Text = $"x = {point.X.ToString()}, y = {point.Y.ToString()}";
                startX = point.X;
                startY = point.Y;
            }
        }
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
