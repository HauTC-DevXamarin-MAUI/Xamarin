using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class MasterDetailPageDemoViewModel : BindableBase
    {
        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand, CanExecuteNavigateCommand));

        void ExecuteNavigateCommand(string uri)
        {
            _navigationService.NavigateAsync(uri); 
        }

        bool CanExecuteNavigateCommand(string uri)
        {
            return true;
        }

        private readonly INavigationService _navigationService;
        public MasterDetailPageDemoViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
