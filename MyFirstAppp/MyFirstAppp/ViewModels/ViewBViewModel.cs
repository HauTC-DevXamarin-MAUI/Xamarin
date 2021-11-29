using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class ViewBViewModel : BindableBase, INavigatedAware
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

        public DelegateCommand NavigateCommand1 =>
            (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand1));

        public ViewBViewModel(INavigationService navigationService)
        {
            Title = "ViewB Của Hậu";
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            //await _navigationService.GoBackAsync();
            await _navigationService.NavigateAsync("/NavigationPage/MainPage");


        }
        async void ExecuteNavigateCommand1()
        {
            //await _navigationService.GoBackAsync();
            await _navigationService.NavigateAsync("ViewC");
        }

        //chạy bất cứ khi điều hướng khỏi View và ViewModel này 
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }
        
        //chạy khi page đưa vào stack
        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("title1");

            //if (parameters.ContainsKey("title1"))
            //{
            //    Title = (string)parameters["title1"];
            //}

            //
            //var r = parameters["title1"] as string;
            //if(r == null)

            //
            //parameters.TryGetValue<string>()
        }

        //Page chưa hiện thị
        public void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}
