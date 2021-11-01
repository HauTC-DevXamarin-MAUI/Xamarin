using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void btnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonPage());
        }

        private void btnSlider_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SliderPage());
        }

        private void btnWebView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebViewPage());
        }

        private void btnLabel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelPage());
        }
    }
}
