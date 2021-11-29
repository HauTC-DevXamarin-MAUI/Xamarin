using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp2.ViewModels
{
    //public class MainPageViewModel : ViewModelBase
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        //public MainPageViewModel(INavigationService navigationService)
        //    : base(navigationService)
        //{
        //    Title = "Main Page";
        //    _navigationService = navigationService;
        //}
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            Title = "Main Page Của Hậu";
            _navigationService = navigationService;
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand, CanExecuteNavigateCommand));

        void ExecuteNavigateCommand()
        {
            _navigationService.NavigateAsync("ViewA");
        }

        bool CanExecuteNavigateCommand()
        {
            return true;
        }
    }
}
