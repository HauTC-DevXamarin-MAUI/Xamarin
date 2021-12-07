using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyApp1.Views.XamarinEssential
{
    public partial class AcclerometerView : ContentPage
    {
        // Đặt độ trễ tốc độ để giám sát các thay đổi.
        SensorSpeed speed = SensorSpeed.UI;

        public AcclerometerView()
        {
            InitializeComponent();


            // Đăng ký đọc các thay đổi, nhớ hủy đăng ký khi hoàn thành
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;

        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var data = e.Reading;

            Console.WriteLine($"Reading: X:{data.Acceleration.X}, Y:{data.Acceleration.Y}, Z:{data.Acceleration.Z}");
            lblStatus.Text = "X: " + data.Acceleration.X + "Y: " + data.Acceleration.Y + "Z: " + data.Acceleration.Z;
        }

        private void ToggleAccelerometer_OnToggled(object sender, ToggledEventArgs e)
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
    }
}
