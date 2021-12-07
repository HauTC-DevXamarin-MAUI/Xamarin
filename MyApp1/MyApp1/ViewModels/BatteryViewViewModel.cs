using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class BatteryViewViewModel : BindableBase
    {
        private string _state;
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }
        private string _level;
        public string Level
        {
            get { return _level; }
            set { SetProperty(ref _level, value); }
        }
        private string _powerSource;
        public string PowerSource
        {
            get { return _powerSource; }
            set { SetProperty(ref _powerSource, value); }
        }
        public BatteryViewViewModel()
        {
            _level = "Level:  " + Battery.ChargeLevel + " ";
            _state = "State:  " + Battery.State + " ";
            _powerSource = "PowerSource:  " + Battery.PowerSource + " ";

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;            
        }


        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            var level = Battery.ChargeLevel;

            var state = Battery.State;
            switch (state)
            {
                case BatteryState.Unknown:
                    //Không thể phát hiện trạng thái pin
                    break;
                case BatteryState.Charging:
                    //đang sạc
                    break;
                case BatteryState.Full:
                    //pin đầy
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    //Hiện đang xả pin hoặc không sạc được
                    break;
                case BatteryState.NotPresent:
                    // pin không hết trong thiết bị
                    break;
            }

            var source = Battery.PowerSource;

            switch (source)
            {
                case BatteryPowerSource.Unknown:
                    break;
                case BatteryPowerSource.Battery:
                    break;
                case BatteryPowerSource.AC:
                    break;
                case BatteryPowerSource.Usb:
                    break;
                case BatteryPowerSource.Wireless:
                    break;
            }
            //_level = "Level  :" + e.ChargeLevel + " ";
            //_state = "State  :" + e.State + " ";
            //_powerSource = "PowerSource  :" + e.PowerSource + " ";
        }
    }
}
