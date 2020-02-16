using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Employee : INotifyPropertyChanged
    {
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { 
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(); // on a retirer "Age"
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "") // CallerMemberName "Age" dans set
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //if (PropertyChanged != null) pareil qu'en haut
            //{
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
        }

        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
