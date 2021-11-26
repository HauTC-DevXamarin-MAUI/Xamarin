using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAppp.ViewModels
{
    public class ViewDViewModel : BindableBase, IConfirmNavigationAsync
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public ViewDViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            Title = "ViewD Của Hậu";
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }
        async void ExecuteNavigateCommand()
        {
            await _navigationService.GoBackToRootAsync();
        }

        public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return _pageDialogService.DisplayAlertAsync("My Title", "Navigation To Root ? ", "Accept", "Cancel");
        }
    }
}
