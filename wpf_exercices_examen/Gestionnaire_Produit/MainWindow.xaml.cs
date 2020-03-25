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
using wpf_models;

namespace Gestionnaire_Produit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        int index = 0;
        private Produit selectedProduct;
        public event PropertyChangedEventHandler PropertyChanged;
        public Produit SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged();
            }
        }

        

        public ObservableCollection<Produit> Products { get; set; } = new ObservableCollection<Produit>();
        public ObservableCollection<string> Categories { get; set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            Products.Add(
                new Produit() { Upc = "523438", Code = "TUE354", ShortDesc = "cubilia Curae; Donec tincidunt.",
                    Desc = "pede, nonummy ut, molestie in, tempus eu, ligula. Aenean", Category = "Electronics",
                    PicturePath = "images/product.png" });
            Products.Add(
                new Produit() { Upc = "536976", Code = "CWQ999", ShortDesc = "enim. Nunc",
                    Desc = "malesuada malesuada. Integer id magna et ipsum cursus vestibulum. Mauris", Category = "Drugs",
                    PicturePath = "images/product.png" });
            Products.Add(
                new Produit() { Upc = "762723", Code = "XVA415", ShortDesc = "nisi a", Desc = "cursus et, magna. Praesent interdum ligula eu enim. Etiam",
                    Category = "Food", PicturePath = "images/product.png" });
            Products.Add(
                new Produit() { Upc = "146509", Code = "YWC365", ShortDesc = "Quisque ornare tortor",
                    Desc = "vel, venenatis vel, faucibus id, libero. Donec consectetuer mauris", Category = "Electronics",
                    PicturePath = "images/product.png" });
            Products.Add(
                new Produit() { Upc = "911706", Code = "LSF234", ShortDesc = "luctus vulputate, nisi", Desc = "et ultrices posuere cubilia Curae;",
                    Category = "Clothing", PicturePath = "images/product.png" });
            Products.Add(
                new Produit() { Upc = "228914", Code = "NDN489", ShortDesc = "sociis natoque", Desc = "diam at pretium aliquet, metus urna convallis",
                    Category = "Drugs", PicturePath = "images/product.png" });
            Products.Add(
                new Produit()
                {
                    Upc = "345007", Code = "GBZ176", ShortDesc = "in felis. Nulla", Desc = "ac risus. Morbi metus. Vivamus euismod urna.",
                    Category = "Drugs", PicturePath = "images/product.png"
                });

            Categories.Add("Clothing");
            Categories.Add("Drugs");
            Categories.Add("Electronics");
            Categories.Add("Food");
            SelectedProduct = Products[index];
            
            //listView.ItemsSource = Products;


        }
        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = listView.SelectedIndex;
            SelectedProduct = Products[index];
            cat.Text = Products[index].Category;
            ListView lv = (ListView)sender;
            SelectedProduct = (Produit)lv.SelectedItem;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
