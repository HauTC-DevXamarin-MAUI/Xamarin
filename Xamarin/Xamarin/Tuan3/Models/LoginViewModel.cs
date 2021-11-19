using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xamarin.Tuan3.Models
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                if(value != _userName)
                {
                    _userName = value;
                    OnPropertyChange();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
