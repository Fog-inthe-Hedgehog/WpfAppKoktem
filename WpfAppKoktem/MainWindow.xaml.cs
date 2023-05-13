using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfAppKoktem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<user> userList = new List<user>();
        //public void DefaultUsers()
        //{
        //    user defaultUser = new user();
        //    defaultUser.name = "Воронюк Надежда Степановна";
        //    defaultUser.telephoneNumber = "+1(234)5678301";
        //    defaultUser.old = "1972";
        //    defaultUser.photo = "C:\\Users\\Prigo\\Desktop\\3.png";

        //    //listUsers.Items.Clear();
        //    listUsers.Items.Add(defaultUser);
        //}
        //public class user : INotifyPropertyChanged
        //{
        //    public string photo { get; set; }
        //    public string name { get; set; }
        //    public string old { get; set; }
        //    public string telephoneNumber { get; set; }

        //    public event PropertyChangedEventHandler PropertyChanged;
        //}
        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
