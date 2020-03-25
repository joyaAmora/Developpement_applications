using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace dea1_s08
{
    public class User
    {
        private string name;
        private DateTime birthday;

        public string Name {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public DateTime Birthday {
            get => birthday;
            set
            {
                birthday = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

