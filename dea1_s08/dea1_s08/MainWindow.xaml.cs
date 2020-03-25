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

namespace dea1_s08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produit> produits;
        public ObservableCollection<Produit> Produits
        {
            get => produits;
            set
            {
                produits = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get => users;
            set
            {
                users = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void initValues()
        {

            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Jade", Birthday = new DateTime(1990, 05, 02) });
            Users.Add(new User() { Name = "John", Birthday = new DateTime(1974, 01, 17) });
            //Produits = new ObservableCollection<Produit>
            //{
            //    new Produit(){Upc = "523438", Code="123"},
            //    new Produit(){Upc = "536976", Code="124"},
            //    new Produit(){Upc = "762723", Code="125"},

            //};

        }
        public MainWindow()
        {
            initValues();
            InitializeComponent();
            
           //Produits.Add( new Produit() { Upc = "111111", Code = "127" });
        }
    }
}
