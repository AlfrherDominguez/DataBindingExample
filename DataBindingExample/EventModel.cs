﻿using System;
using System.ComponentModel;

namespace DataBindingExample
{
    class Evento : INotifyPropertyChanged
    {
        private string title; private DateTime date; public string Title
        {
            get => title; set
            {
                if (value != title) 
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public DateTime Date 
        { get => date; 
          set 
            { 
                if (value != date) 
                { 
                    date = value;
                } 
            } 
        }
        public event PropertyChangedEventHandler PropertyChanged; 
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) 
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            } 
        }
    }
}
