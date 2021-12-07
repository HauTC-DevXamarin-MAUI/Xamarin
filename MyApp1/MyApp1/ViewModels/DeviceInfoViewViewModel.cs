using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class DeviceInfoViewViewModel : BindableBase
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }
        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { SetProperty(ref _manufacturer, value); }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private string _versionString;
        public string VersionString
        {
            get { return _versionString; }
            set { SetProperty(ref _versionString, value); }
        }
        private string _platform;
        public string Platform
        {
            get { return _platform; }
            set { SetProperty(ref _platform, value); }
        }
        private string _idiom;
        public string Idiom
        {
            get { return _idiom; }
            set { SetProperty(ref _idiom, value); }
        }
        private string _deviceType;
        public string DeviceType
        {
            get { return _deviceType; }
            set { SetProperty(ref _deviceType, value); }
        }
        public DeviceInfoViewViewModel()
        {
            GetDeviceInfo();
        }

        private void GetDeviceInfo()
        {
            // Device Model (SMG-950U, iPhone10,6)
            var device = DeviceInfo.Model;

            // Manufacturer (Samsung)
            var manufacturer = DeviceInfo.Manufacturer;

            // Device Name (Motz's iPhone)
            var deviceName = DeviceInfo.Name;

            // Operating System Version Number (7.0)
            var version = DeviceInfo.VersionString;

            // Platform (Android)
            var platform = DeviceInfo.Platform;

            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;

            _model = "Device:  "+ device;
            _manufacturer = "manufacturer:  " + manufacturer;
            _name = "deviceName:  " + deviceName;
            _versionString = "version:  " + version;
            _platform = "platform:  " + platform;
            _idiom = "idiom:  " + idiom;
            _deviceType = "deviceType:  " + deviceType;
        }
    }
}
