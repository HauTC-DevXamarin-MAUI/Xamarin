using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp1.ViewModels
{
    public class MessagingCenterSendViewViewModel : BindableBase, INotifyPropertyChanged
    {
        //private readonly INavigationService _navigationService;
        //public MessagingCenterSendViewViewModel(INavigationService navigationService)
        //{
        //    _navigationService = navigationService;
        //}

        //#region SendCommand
        //private DelegateCommand _sendCommand;
        //public DelegateCommand SendCommand =>
        //    _sendCommand ?? (_sendCommand = new DelegateCommand(ExecuteSendCommand, CanExecuteSendCommand));

        //void ExecuteSendCommand()
        //{
        //    MessagingCenter.Send<MessagingCenterSendViewViewModel, DateTime>(this, "tick", DateTime.Now);
        //}

        //bool CanExecuteSendCommand()
        //{
        //    return true;
        //}
        //#endregion

        //#region GoBackCommand
        //private DelegateCommand _goBackCommand;
        //public DelegateCommand GoBackCommand =>
        //    _goBackCommand ?? (_goBackCommand = new DelegateCommand(ExecuteGoBackCommand, CanExecuteGoBackCommand));

        //async void ExecuteGoBackCommand()
        //{
        //    await _navigationService.GoBackAsync();
        //}

        //bool CanExecuteGoBackCommand()
        //{
        //    return true;
        //}
        //#endregion


        public MessagingCenterSendViewViewModel()
        {
        }

    }
}
