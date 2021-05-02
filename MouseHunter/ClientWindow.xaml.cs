using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MouseHunter.ServiceReference;
using WcfMouceService;

namespace MouseHunter
{

    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        //List<MouseEv> list = new List<MouseEv>();
        ObservableCollection<MouseEv> list = new ObservableCollection<MouseEv>(); 
        bool btnFlag = false; // флаг для кнопки старт/стоп
        
        double startX = 150;
        double startY = 150;
        public ClientWindow()
        {
            InitializeComponent();
        }
        private void displayArea_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client service = new ServiceReference.Service1Client();
            DataTable dataTable = new DataTable();
            dataTable = service.LoadFromDB();
            dgEventsList.ItemsSource = dataTable.DefaultView;

            //GetEventData eventData = new GetEventData();
            //eventData = service.GetInfo();
            //DataTable dt = new DataTable();
            //dt = eventData.EventTable;
            //dgEventsList.DataContext = dt;

        }
        private void displayArea_MouseRightDown(object sender, MouseButtonEventArgs e)
        {
            string mes = "Right button pressed";
            
            DateTime dateTime = DateTime.Now;
            Point p = e.GetPosition(this);

            list.Add(new MouseEv()
            {
                Date = dateTime,
                MouseEvent = mes,
                Coordinate = $"x = {p.X.ToString()}, y = {p.Y.ToString()}"
            });
            countLbl.Content = list.Count().ToString();
        }
        private void displayArea_MouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            string mes = "Left button pressed";
            DateTime dateTime = DateTime.Now;
            Point p = e.GetPosition(this);

            list.Add(new MouseEv()
            {
                Date = dateTime,
                MouseEvent = mes,
                Coordinate = $"x = {p.X.ToString()}, y = {p.Y.ToString()}"
            }); 
            countLbl.Content = list.Count().ToString();
        }
        private void displayArea_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            string mes = "Middle button pressed"; //реагирует на кручение колеса, не на нажатеие (((
            DateTime dateTime = DateTime.Now;
            Point p = e.GetPosition(this);

            list.Add(new MouseEv()
            {
                Date = dateTime,
                MouseEvent = mes,
                Coordinate = $"x = {p.X.ToString()}, y = {p.Y.ToString()}"
            }); 
            countLbl.Content = list.Count().ToString();
        }
        private void displayArea_MouseMove(object sender, MouseEventArgs e)
        {
            string mes = "Mouse moved";
            DateTime dateTime = DateTime.Now;
            Point point = e.GetPosition(this);
            //Point locationBtn = startBtn.PointToScreen(new Point(0, 0)); // зададим начальные координаты для отчета смещения мыши
            
            double x = point.X;
            double y = point.Y;

            if (Math.Abs(startX - x) > 10 || Math.Abs(startY - y) > 10)
            {
                //list.Add(new MouseEv()
                //{
                //    DateTime = dateTime,
                //    Content = mes,
                //    Coordinate = mess(mes, point, dateTime)
                //});

                //mess(mes, point, dateTime);
                countLbl.Content = list.Count().ToString();
            }
        }
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
           
            ServiceReference.Service1Client service = new ServiceReference.Service1Client();
            try
            {
                foreach(var ev in list)
                {
                    service.Insert(ev);
                }
            }
            catch (Exception) { }
            
            
        }


        //public string mess(string m, Point p, DateTime time)
        //{
        //    string coord = $"x = {p.X.ToString()}, y = {p.Y.ToString()}";
        //    coordinateTb.Text = coord;
        //    contentTb.Text = $"{m}";
        //    dateTb.Text = time.ToString();
        //    return coord;
        //}


    }
}
