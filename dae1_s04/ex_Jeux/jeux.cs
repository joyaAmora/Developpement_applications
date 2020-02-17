using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex_Jeux
{
    public class Jeux: INotifyPropertyChanged
    {
        private string titre;
        private string edition;
        private int annee;
        private string konsole;
        private string imagePath;
        private int cote;
        private string desc;

        public string Titre
        {
            get => titre;
            set
            {
                titre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }

        

        public string Edition
        {
            get => edition;
            set
            {
                edition = value;
                OnPropertyChanged();
            }
        }
        public int Annee
        {
            get => annee;
            set
            {
                annee = value;
                OnPropertyChanged();
            }
        }
        public string Konsole
        {
            get => konsole;
            set
            {
                konsole = value;
                OnPropertyChanged();
            }
        }
        public string Desc
        {
            get => desc;
            set
            {
                desc = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }
        public string ImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                OnPropertyChanged();
            }
        }
        public int Cote
        {
            get => cote;
            set
            {
                cote = value;
                OnPropertyChanged();
            }
        } 
        public string Info
        {
            get => titre + ": " + desc;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
