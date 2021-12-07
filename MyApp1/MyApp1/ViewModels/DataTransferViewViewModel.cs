using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class DataTransferViewViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        private string _titleUrl;
        public string TitleUrl
        {
            get { return _titleUrl; }
            set { SetProperty(ref _titleUrl, value); }
        }
        private string _textUrl;
        public string TextUrl
        {
            get { return _textUrl; }
            set { SetProperty(ref _textUrl, value); }
        }

        private DelegateCommand _shareTextCommand;
        public DelegateCommand ShareTextCommand =>
            _shareTextCommand ?? (_shareTextCommand = new DelegateCommand(ExecuteShareTextCommand));

        async void ExecuteShareTextCommand()
        {
            await Share.RequestAsync(new ShareTextRequest 
            {
                Text = _text,
                Title = _title,
            });
        }

        private DelegateCommand _shareUrlCommand;
        public DelegateCommand ShareUrlCommand =>
            _shareUrlCommand ?? (_shareUrlCommand = new DelegateCommand(ExecuteShareUrlCommand));

        async void ExecuteShareUrlCommand()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = _textUrl,
                Title = _titleUrl,
            });
        }
        public DataTransferViewViewModel()
        {

        }
    }
}
