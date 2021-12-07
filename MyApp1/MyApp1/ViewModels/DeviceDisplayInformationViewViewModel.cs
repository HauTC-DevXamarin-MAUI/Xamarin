using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class DeviceDisplayInformationViewViewModel : BindableBase
    {
        private string _orientation;
        public string Orientation
        {
            get { return _orientation; }
            set { SetProperty(ref _orientation, value); }
        }
        private string _rotation;
        public string Rotation
        {
            get { return _rotation; }
            set { SetProperty(ref _rotation, value); }
        }
        private string _width;
        public string Width
        {
            get { return _width; }
            set { SetProperty(ref _width, value); }
        }

        private string _height;
        public string Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private string _density;
        public string Density
        {
            get { return _density; }
            set { SetProperty(ref _density, value); }
        }
        public DeviceDisplayInformationViewViewModel()
        {
            GetMetrics();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            // Get Metrics
            var mainDisplayInfo = e.DisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            var rotation = mainDisplayInfo.Rotation;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;

            // Screen density
            var density = mainDisplayInfo.Density;


            _orientation = "Orientation: " + orientation;
            _width = "Width: " + width;
            _height = "Height: " + height;
            _density = "Density: " + density;
            _rotation = "Rotation: " + rotation;
        }

        private void GetMetrics()
        {
            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            var rotation = mainDisplayInfo.Rotation;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;

            // Screen density
            var density = mainDisplayInfo.Density;


            _orientation = "Orientation: " + orientation;
            _width = "Width: " + width;
            _height = "Height: " + height;
            _density = "Density: " + density;
            _rotation = "Rotation: " + rotation;

        }
    }
}
