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
using MouseHunter.Model;

namespace MouseHunter
{

    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        List<MouseEv> list = new List<MouseEv>();
        double startX = 150;
        double startY = 150;
        public ClientWindow()
        {
            InitializeComponent();
            
        }
        private void displayArea_MouseRightDown(object sender, MouseButtonEventArgs e)
        {
            string mes = "ПКМ нажата";
            DateTime dateTime = DateTime.Now;
            Point point = e.GetPosition(this);

            list.Add(new MouseEv()
            {
                DateTime = dateTime,
                Content = mes,
                Coordinate = mess(mes, point, dateTime)
            });
        }
        private void displayArea_MouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            string mes = "ЛКМ нажата";
            DateTime dateTime = DateTime.Now;
            Point point = e.GetPosition(this);

            list.Add(new MouseEv() { DateTime = dateTime, 
                                     Content = mes, 
                                     Coordinate = mess(mes, point, dateTime) 
            });
        }
        private void displayArea_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            string mes = "CКМ нажата"; //реагирует на кручение колеса, не на нажатеие (((
            DateTime dateTime = DateTime.Now;
            Point point = e.GetPosition(this);

            list.Add(new MouseEv()
            {
                DateTime = dateTime,
                Content = mes,
                Coordinate = mess(mes, point, dateTime)
            });
        }
        private void displayArea_MouseMove(object sender, MouseEventArgs e)
        {
            string mes = "Мышь сдвинулась";
            DateTime dateTime = DateTime.Now;
            Point point = e.GetPosition(this);
            //Point locationBtn = startBtn.PointToScreen(new Point(0, 0)); // зададим начальные координаты для отчета смещения мыши
            
            double x = point.X;
            double y = point.Y;

            if (Math.Abs(startX - x) > 100 || Math.Abs(startY - y) > 100)
            {
                //list.Add(new MouseEv()
                //{
                //    DateTime = dateTime,
                //    Content = mes,
                //    Coordinate = mess(mes, point, dateTime)
                //});

                mess(mes, point, dateTime);

            }
        }
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client service = new ServiceReference.Service1Client();
            try
            {
                foreach(var ev in list)
                {
                    service.Insert(ev.DateTime, ev.Content, ev.Coordinate);
                }
            }
            catch (Exception) { }
            
        }
        public string mess(string m, Point p, DateTime time)
        {
            string coord = $"x = {p.X.ToString()}, y = {p.Y.ToString()}";
            coordinateTb.Text = coord;
            contentTb.Text = $"{m}";
            dateTb.Text = time.ToString();
            return coord;
        }


    }
}
