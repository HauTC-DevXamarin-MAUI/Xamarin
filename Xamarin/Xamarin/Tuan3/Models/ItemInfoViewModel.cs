using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.Tuan3.Models
{
    public class ItemInfoViewModel :INotifyPropertyChanged
    {
        public ICommand SubmitCommand => new Command(Submit);

        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string _message { get; set; }
        public string Message 
        { 
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChange();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged == null)
            {
                return;
            }
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Submit()
        {
            Message = "Save Item: Name: " + this.ItemName + " , " + "Price: " + this.Price;
        }
    }
    //public class ItemInfoViewModel
    //{
    
    //    public string ItemName
    //    { get; set; }
    //    public decimal Price { get; set; }
    //}
}
