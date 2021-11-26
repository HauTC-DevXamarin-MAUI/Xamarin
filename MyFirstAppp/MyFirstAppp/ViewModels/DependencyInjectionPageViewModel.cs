using MyFirstAppp.Interfaces;
using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
        public class DependencyInjectionPageViewModel : BindableBase 
    {
            private readonly ICustomService _extServices;
            private ObservableCollection<string> _customersName = new ObservableCollection<string>();

            public DependencyInjectionPageViewModel(ICustomService extServices)
            {
                _extServices = extServices;
                _extServices.GetCustomersName().ForEach(name => _customersName.Add(name));
            }

            public ObservableCollection<string> Names
            {
                get { return _customersName; }
            }

    }
}
