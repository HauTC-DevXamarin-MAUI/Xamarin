using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class FlashlightViewViewModel : BindableBase
    {
        private DelegateCommand _turnOnCommand;
        public DelegateCommand TurnOnCommand =>
            _turnOnCommand ?? (_turnOnCommand = new DelegateCommand(ExecuteTurnOnCommand));

        async void ExecuteTurnOnCommand()
        {
            try
            {
                // Turn On
                await Flashlight.TurnOnAsync();

            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
            }
        }
        private DelegateCommand _turnOffCommand;
        public DelegateCommand TurnOffCommand =>
            _turnOffCommand ?? (_turnOffCommand = new DelegateCommand(ExecuteTurnOffCommand));

        async void ExecuteTurnOffCommand()
        {
            try
            {
                // Turn Off
                await Flashlight.TurnOffAsync();
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to turn on/off flashlight
            }
        }
        public FlashlightViewViewModel()
        {

        }
    }
}
