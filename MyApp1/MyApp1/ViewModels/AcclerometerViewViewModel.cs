using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class AcclerometerViewViewModel : BindableBase
    {
        SensorSpeed speed = SensorSpeed.UI;


        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        #region ToogledComand
        private DelegateCommand _toogledComand;
        public DelegateCommand ToogledComand =>
            _toogledComand ?? (_toogledComand = new DelegateCommand(ExecuteOpenCommand, CanExecuteOpenCommand));

        void ExecuteOpenCommand()
        {
            try
            {
                if (Accelerometer.IsMonitoring)
                {
                    Accelerometer.Stop();
                }
                else
                    Accelerometer.Start(speed);
            }
            catch (Exception ex)
            {

            }
        }

        bool CanExecuteOpenCommand()
        {
            return true;
        }
        #endregion
        public AcclerometerViewViewModel()
        {
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var data = e.Reading;
            
            Console.WriteLine($"Reading: X:{data.Acceleration.X}, Y:{data.Acceleration.Y}, Z:{data.Acceleration.Z}");
            _status = "X: " + data.Acceleration.X + "Y: " + data.Acceleration.Y + "Z: " + data.Acceleration.Z;
        }
    }
}
