using System;
using System.Collections.Generic;
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
    public partial class MainWindow : INotifyPropertyChanged
    {
        public List<Jeux> jeux { get; set; }
        public Jeux jeuSelectionne { get; set; }
        public MainWindow()
        {
            jeux = new List<Jeux>()
            {
                new Jeux()
                {
                    Titre = "Super Mario",
                    Edition = "edition1",
                    Annee = 1980,
                    Konsole = "SNESS",
                    Desc = "Super jeu 80's",
                    ImagePath = "images/super-mario.jpg",
                    Cote = 4
                },
                new Jeux()
                {
                    Titre = "Fire Emblem",
                    Edition = "edition2",
                    Annee = 2018,
                    Konsole = "Switch",
                    Desc = "J'adore!",
                    ImagePath = "images/fire-emblem.jpg",
                    Cote = 5
                },
                new Jeux()
                {
                    Titre = "Final Fantasy XIII",
                    Edition = "edition3",
                    Annee = 2012,
                    Konsole = "PS3",
                    Desc = "Easy to play",
                    ImagePath = "images/finalFantasy.jpg",
                    Cote = 5
                },
            };
            jeuSelectionne = jeux[0];
            InitializeComponent();

        
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (scroll.Value > 3)
            {
                scroll.Value = 3;
            }
            else
            {
                jeuSelectionne = jeux[Convert.ToInt32(scroll.Value) - 1];
                OnPropertyChanged("jeuSelectionne");
            }
        }
    }
}
