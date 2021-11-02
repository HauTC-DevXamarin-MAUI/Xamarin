using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        
        public DatePickerPage()
        {
            InitializeComponent();
            
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblDay.Text = "Ngày hôm nay là: " + datePickerHau.Date.ToShortDateString().ToString();
        }
      
    }
}