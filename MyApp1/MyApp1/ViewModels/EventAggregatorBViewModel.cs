using MyApp1.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp1.ViewModels
{
    public class EventAggregatorBViewModel : BindableBase
    {
        protected IEventAggregator _ea;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private DelegateCommand _onSendCommand;
        public DelegateCommand OnSendCommand =>
            _onSendCommand ?? (_onSendCommand = new DelegateCommand(HandleSend));

        void HandleSend()
        {
         
            _ea.GetEvent<MessageSentEvent>().Publish(Message);
        }

        public EventAggregatorBViewModel(IEventAggregator ea)
        {
            _ea = ea;
        }

    }
}

