using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace MyApp1.ViewModels
{
    public class MessagingCenterSubcribeViewViewModel : BindableBase, INotifyPropertyChanged
    {
        //public ObservableCollection<string> MessagingItems { get; set; } = new ObservableCollection<string>();
        //private readonly INavigationService _navigationService;
        //public MessagingCenterSubcribeViewViewModel(INavigationService navigationService)
        //{
        //    _navigationService = navigationService;
        //}
       

        //#region Command SubscribeCommand
        //private DelegateCommand _subscribeCommand;
        //public DelegateCommand SubscribeCommand =>
        //    _subscribeCommand ?? (_subscribeCommand = new DelegateCommand(ExecuteSubscribeCommand, CanExecuteSubscribeCommand));

        //void ExecuteSubscribeCommand()
        //{
        //    MessagingCenter.Subscribe<MessagingCenterSubcribeViewViewModel, DateTime>(this, "tick", (p, datetime) =>
        //    {
        //        MessagingItems.Add($"Message received at {datetime}");
        //    });
        //}

        //bool CanExecuteSubscribeCommand()
        //{
        //    return true;
        //}
        //#endregion

        //#region command GoToPageCommand
        //private DelegateCommand _goToPageCommand;
        //public DelegateCommand GoToPageCommand =>
        //    _goToPageCommand ?? (_goToPageCommand = new DelegateCommand(ExecuteGoToPageCommand, CanExecuteGoToPageCommand));

        //async void ExecuteGoToPageCommand()
        //{
        //    await _navigationService.NavigateAsync("MessagingCenterSendView");
        //}

        //bool CanExecuteGoToPageCommand()
        //{
        //    return true;
        //}
        //#endregion

        public MessagingCenterSubcribeViewViewModel()
        {
            
        }
    }
}
