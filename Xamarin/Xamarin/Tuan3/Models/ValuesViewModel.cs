using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xamarin.Tuan3.Models
{
    public class ValuesViewModel : INotifyPropertyChanged
    {
        #region init
        public ValuesViewModel()
        {
            _intInput = 100;
        }
        //public void InitializeValues()
        //{
        //    _intInput = 100;
        //}

        public void UpdateValues()
        {
            //this._intInput = _intInput + 10;
        }
        #endregion


        private int _intInput;
        public int intInput
        {
            get { return _intInput; }
            set
            {
                if (value != _intInput)
                {
                    _intInput = value;
                    NotifyproperttyChanged();
                }
            }
        }
        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyproperttyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
    }
}
