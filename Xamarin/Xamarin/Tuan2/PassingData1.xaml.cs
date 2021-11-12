using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassingData1 : ContentPage
    {
        public PassingData1(string title=null, string notify = null)
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(notify))
            {
                lblNotification.Text = notify;
                Title = title;
                DisplayAlert("Notification", notify, "Ok");
            }
        }
    }
}