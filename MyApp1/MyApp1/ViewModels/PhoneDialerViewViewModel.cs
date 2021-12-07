using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class PhoneDialerViewViewModel : BindableBase
    {
        private string _entryNumber;
        public string EntryNumber
        {
            get { return _entryNumber; }
            set { SetProperty(ref _entryNumber, value); }
        }

        private DelegateCommand _callCommand;
        public DelegateCommand CallCommand =>
            _callCommand ?? (_callCommand = new DelegateCommand(ExecuteCommandName));

        async void ExecuteCommandName()
        {
            await PlacePhoneCall(_entryNumber);
        }

        public async Task PlacePhoneCall(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
        public PhoneDialerViewViewModel()
        {

        }
    }
}
