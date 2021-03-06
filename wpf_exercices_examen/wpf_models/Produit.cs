﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace wpf_models
{
    public class Produit: INotifyPropertyChanged
    {
        private string upc;
        private string code;
        private string shortDesc;
        private string desc;
        private string category;
        private string picturePath;

        public string Upc {
            get => upc;
            set
            {
                upc = value;
                OnPropertyChanged();
            }
        }
        public string Code {
            get => code;
            set
            {
                code = value;
                OnPropertyChanged();
            }
        }
        public string ShortDesc {
            get => shortDesc;
            set
            {
                shortDesc = value;
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
            }
        }
        public string Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged();
            }
        }        
        
        public string PicturePath
        {
            get => picturePath;
            set
            {
                picturePath = value;
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
