using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class GeolocationViewViewModel : BindableBase
    {
        protected IPageDialogService _dialogService;

        public GeolocationViewViewModel(IPageDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        private DelegateCommand _getLocationCommand;
        public DelegateCommand GetLocationCommand =>
            _getLocationCommand ?? (_getLocationCommand = new DelegateCommand(ExecuteGetLocationCommand));

        async void ExecuteGetLocationCommand()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    var latitude = location.Latitude;
                    var longitude = location.Longitude;
                    var altiude = location.Altitude;
                    _dialogService.DisplayAlertAsync("Get Location", latitude.ToString() + "" + longitude.ToString(), "OK");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
