using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class ViewCViewModel : BindableBase,IConfirmNavigation
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public ViewCViewModel(INavigationService navigationService)
        {
            Title = "ViewC Của Hậu";
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("ViewD");
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            ////Navigation đươc 
            return true;
            //Navigation đươc 
            //return false;

        }
    }
}
