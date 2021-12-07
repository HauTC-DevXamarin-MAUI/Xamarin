using MyApp1.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class EventAggregatorListViewViewModel : BindableBase
    {
        IEventAggregator _ea;
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();


        public EventAggregatorListViewViewModel(IEventAggregator ea)
        {
            _ea = ea;
            Messages.Add("aa");
            //ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);

        }
        private DelegateCommand _subscribeCommand;
        public DelegateCommand SubscribeCommand =>
            _subscribeCommand ?? (_subscribeCommand = new DelegateCommand(ExecuteSubscribeCommand, CanExecuteSubscribeCommand));

        void ExecuteSubscribeCommand()
        {
            _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived, ThreadOption.UIThread);
        }

        bool CanExecuteSubscribeCommand()
        {
            return true;
        }

        private void MessageReceived(string parameter)
        {

                Messages.Add(parameter);
        }
    }
}
