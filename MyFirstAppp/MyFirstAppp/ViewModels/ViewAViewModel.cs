using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class ViewAViewModel : BindableBase
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

        public ViewAViewModel(INavigationService navigationService)
        {
            Title = "View A Của Hậu";
            //Navigation
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            //C1
            var p = new NavigationParameters();
            p.Add("title", "Hello ViewB");
            p.Add("title1", "Hello ViewB 1");

            //C2
            //var p2 = new NavigationParameters("id=1&name=brian&color=blue");


            await _navigationService.NavigateAsync("ViewB",p);
        }

    }
}
