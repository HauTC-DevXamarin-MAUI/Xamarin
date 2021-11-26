using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Tuan4.Model;

namespace Xamarin.Tuan4.ViewModel
{
    class MyViewModel : INotifyPropertyChanged
    {
        #region Implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = " ") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion


        public MyViewModel()
        {
            Model = new MyModel();

            AddCommand = new Command(AddAction);
        }

        #region Property
        public MyModel Model { get; set; }
        public ICommand AddCommand { get; private set; }
        public int ItemsCount => Model.Items.Count;
        #endregion
        private void Add()
        {
            var newitem = new Item() { Data = Model.Items.Count + 1 };
            Model.Items.Add(newitem);
            NotifyPropertyChanged(nameof(ItemsCount));
        }


        private void AddAction(object obj)
        {
            Add();
        }
    }
}
