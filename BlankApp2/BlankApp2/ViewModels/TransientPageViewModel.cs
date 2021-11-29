using BlankApp2.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BlankApp2.ViewModels
{
    public class TransientPageViewModel : BindableBase
    {

        private readonly INavigationService _navigationService;

        private ObservableCollection<int> _listCustomer;
        public ObservableCollection<int> ListCustomer
        {
            get { return _listCustomer; }
            set { SetProperty(ref _listCustomer, value); }
        }

        //private int numberValue;

        //public int NumberValue
        //{
        //    get => numberValue;
        //    set => SetProperty(ref numberValue, value);
        //}

        public TransientPageViewModel(INavigationService navigationService, ITheSecondService theSecondService)
        {
            _navigationService = navigationService;
            ListCustomer = new ObservableCollection<int>(theSecondService.ListCustomer);
            //NumberValue = customService.NumberValue;
        }
    }
}
