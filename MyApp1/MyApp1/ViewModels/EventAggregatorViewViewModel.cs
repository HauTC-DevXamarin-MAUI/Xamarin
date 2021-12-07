using MyApp1.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp1.ViewModels
{
    public class EventAggregatorViewViewModel : BindableBase
    {
        IEventAggregator _ea;
        private string _message = "Mess to send";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        private DelegateCommand _sendMessageCommand;
        public DelegateCommand SendMessageCommand =>
            _sendMessageCommand ?? (_sendMessageCommand = new DelegateCommand(ExecuteSendMessageCommand, CanExecuteSendMessageCommand));

        void ExecuteSendMessageCommand()
        {
            _ea.GetEvent<MessageSentEvent>().Publish(Message);
        }
        
        bool CanExecuteSendMessageCommand()
        {
            return true;
        }

        public EventAggregatorViewViewModel(IEventAggregator ea)
        {
            _ea = ea;
        }
    }
}
