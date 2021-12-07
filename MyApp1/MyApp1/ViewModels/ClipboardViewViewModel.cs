using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class ClipboardViewViewModel : BindableBase, INotifyPropertyChanged
    {
        private string _entryInput;
        public string EntryInput
        {
            get { return _entryInput; }
            set { SetProperty(ref _entryInput, value); }
        }
        private string _yourText;
        public string YourText
        {
            get { return _yourText; }
            set { SetProperty(ref _yourText, value); }
        }

        public ClipboardViewViewModel(IPageDialogService dialogService)
        {
            _dialogService = dialogService;
            _yourText = "Your text here!";
        }


        private DelegateCommand _copyComand;
        public DelegateCommand CopyCommand =>
            _copyComand ?? (_copyComand = new DelegateCommand(ExecuteCopyCommand));

        void ExecuteCopyCommand()
        {
            Clipboard.SetTextAsync(_entryInput);
        }
        private DelegateCommand _pasteCommand;
        public DelegateCommand PasteCommand =>
            (_pasteCommand = new DelegateCommand(ExecutePasteCommand));

        protected IPageDialogService _dialogService;
        async void ExecutePasteCommand()
        {
            if(Clipboard.HasText == true)
            {
                _yourText = await Clipboard.GetTextAsync();
                _dialogService.DisplayAlertAsync("GetTextAsync", _yourText, "OK");
            }
            else
            {
                _yourText = "No text in clipboard";
                _dialogService.DisplayAlertAsync("GetTextAsync", _yourText, "OK");
            }
        }
    }
}
