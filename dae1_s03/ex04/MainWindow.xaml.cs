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

namespace ex04
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "You seleted the color ";
            if (red.IsChecked == true)
            {
                textBox1.Text += red.Name;
            }
            if (blue.IsChecked == true)
            {
                textBox1.Text += blue.Name;
            }
            if (yellow.IsChecked == true)
            {
                textBox1.Text += yellow.Name;
            }
        }        
        private void Radio_Button_Selected(object sender, RoutedEventArgs e)
        {
            if (red.IsChecked == true)
            {
                ellipse1.Fill= (SolidColorBrush)new BrushConverter().ConvertFromString(red.Name);
            }            
            if (blue.IsChecked == true)
            {
                ellipse1.Fill= (SolidColorBrush)new BrushConverter().ConvertFromString(blue.Name);
            }           
            if (yellow.IsChecked == true)
            {
                ellipse1.Fill= (SolidColorBrush)new BrushConverter().ConvertFromString(yellow.Name);
            }
        }


    }
}
