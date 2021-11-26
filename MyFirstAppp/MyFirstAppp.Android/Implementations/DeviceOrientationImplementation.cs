using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstAppp.Droid.Implementations;
using MyFirstAppp.Interfaces;
using MyFirstAppp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationImplementation))]
namespace MyFirstAppp.Droid.Implementations
{
    class DeviceOrientationImplementation : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager =
                Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}