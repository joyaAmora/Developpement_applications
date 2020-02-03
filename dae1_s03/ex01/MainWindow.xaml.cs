using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Allo"); // C'est ici qu'on met le code qui est appelé par MainWindow
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Bouton cliqué");
        }

        private void Button_Click_repeteur(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Bouton répéteur");
        }

        private void Button_Click_Bascule(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Bouton bascule");
        }

        private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                CheckBox_Checked(sender, e);
            }
            else if (checkBox1.IsChecked == false)
                {
                    CheckBox_UnChecked(sender, e);
                }
            else
            {
                CheckBox_Indeterminate(sender, e);
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Coché");
        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Décoché");
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Indéterminé");
        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Coché");
        }

        private void Radio_UnChecked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Décoché");
        }

        private void Radio_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked == true)
            {
                Radio_Checked(sender, e);
            }
            else if (checkBox1.IsChecked == false)
            {
                Radio_UnChecked(sender, e);
            }
            

        }
    }
}
