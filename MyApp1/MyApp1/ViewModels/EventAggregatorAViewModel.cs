using MyApp1.Models;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyApp1.ViewModels
{
    public class EventAggregatorAViewModel
    {
        protected IEventAggregator _ea;
        protected SubscriptionToken _token;
        public ObservableCollection<string> Collection { get; set; } = new ObservableCollection<string>();

        private DelegateCommand _onSubscribeCommand;
        public DelegateCommand OnSubscribeCommand =>
            _onSubscribeCommand ?? (_onSubscribeCommand = new DelegateCommand(HandleSubscribe));

        void HandleSubscribe()
        {
            _token = _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived, ThreadOption.UIThread);
        }

        private void MessageReceived(string obj)
        {
            Collection.Add(obj);
        }

        private DelegateCommand _onUnSubscribeCommand;
        public DelegateCommand OnUnSubscribeCommand =>
            _onUnSubscribeCommand ?? (_onUnSubscribeCommand = new DelegateCommand(HandleUnSubscribe));

        void HandleUnSubscribe()
        {

            _ea.GetEvent<MessageSentEvent>().Unsubscribe(_token);
        }


        public EventAggregatorAViewModel(IEventAggregator ea)
        {
            _ea = ea;
        }

    }
}
