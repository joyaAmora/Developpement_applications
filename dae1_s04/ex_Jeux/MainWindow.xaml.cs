using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ex_Jeux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Jeux jeuSelectionne;
        int index = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Jeux> jeux { get; set; } = new ObservableCollection<Jeux>();

        public ObservableCollection<string> Konsoles { get; set; } = new ObservableCollection<string>();
        public Jeux JeuSelectionne { 
            get => jeuSelectionne; 
            set {
                jeuSelectionne = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            jeux.Add(
                new Jeux
                {
                    Titre = "Super Mario",
                    Edition = "edition1",
                    Annee = 1980,
                    Konsole = "SNESS",
                    Desc = "Super jeu 80's",
                    ImagePath = "images/super-mario.jpg",
                    Cote = 4
                });
            jeux.Add(
                new Jeux
                {
                    Titre = "Fire Emblem",
                    Edition = "edition2",
                    Annee = 2018,
                    Konsole = "Switch",
                    Desc = "J'adore!",
                    ImagePath = "images/fire-emblem.jpg",
                    Cote = 5
                });
            jeux.Add(
                new Jeux
                {
                    Titre = "Final Fantasy XIII",
                    Edition = "edition3",
                    Annee = 2012,
                    Konsole = "PS3",
                    Desc = "Easy to play",
                    ImagePath = "images/finalFantasy.jpg",
                    Cote = 5
                });
            jeux.Add(
                new Jeux
                {
                    Titre = "Super Mario",
                    Edition = "edition1",
                    Annee = 1980,
                    Konsole = "SNESS",
                    Desc = "Super jeu 80's",
                    ImagePath = "images/super-mario.jpg",
                    Cote = 4
                });

            Konsoles.Add("PS3");
            Konsoles.Add("SNESS");
            Konsoles.Add("PC");
            Konsoles.Add("Switch");
            JeuSelectionne = jeux[index];
            InitializeComponent();
            listView.ItemsSource = jeux;

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (scroll.Value > 4)
            {
                scroll.Value = 4;
            }
            else
            {
                JeuSelectionne = jeux[Convert.ToInt32(scroll.Value) - 1];
                consoleSelector.Text = JeuSelectionne.Konsole;
            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = listView.SelectedIndex;
            JeuSelectionne = jeux[index];
            consoleSelector.Text = jeux[index].Konsole;
            ListView lv = (ListView)sender;
            JeuSelectionne = (Jeux)lv.SelectedItem;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            JeuSelectionne = new Jeux();
            jeux.Add(JeuSelectionne);
            //var temp = new Jeux()
            //{
            //    Titre = titre.Text,
            //    Edition = edition.Text,
            //    Annee = Convert.ToInt32(annee.Text),
            //    Konsole = consoleSelector.Text,
            //    Desc = desc.Text,
            //    ImagePath = "images/finalFantasy.jpg",
            //    Cote = Convert.ToInt32(sliderCote.Value),
            //};
            //jeux.Add(temp);
        }

        private void Image_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
               JeuSelectionne.ImagePath = op.FileName;
            }
        }
    }
}
