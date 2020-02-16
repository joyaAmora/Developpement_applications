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

namespace ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Employee employee { get; set; }
        public MainWindow()
        {
            employee = new Employee()
            {
                Age = 45,
                LastName = "Seeman",
                Name = "Mark",
                PicturePath = "images/img.jpg"
            };
        InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee.Age = 40;
        }
    }
}
