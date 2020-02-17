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

namespace ex05
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

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Random RandomNumber = new Random();

            Grid.SetRow(hack, RandomNumber.Next(0,2));
            Grid.SetColumn(hack, RandomNumber.Next(0,2));            
            
            Grid.SetRow(logo, RandomNumber.Next(0,2));
            Grid.SetColumn(logo, RandomNumber.Next(0,2));
            
            Grid.SetRow(logo1, RandomNumber.Next(0,2));
            Grid.SetColumn(logo1, RandomNumber.Next(0,2));
            
            Grid.SetRow(bg, RandomNumber.Next(0,2));
            Grid.SetColumn(bg, RandomNumber.Next(0,2));
            
        }
    }
}
