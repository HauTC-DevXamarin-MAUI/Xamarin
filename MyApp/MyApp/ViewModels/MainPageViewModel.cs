﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _apiCommand;
        public DelegateCommand ApiCommand =>
             _apiCommand ?? ( _apiCommand = new DelegateCommand(ExecuteApiCommand));

        void ExecuteApiCommand()
        {            
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
