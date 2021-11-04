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

        private void btnEntry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        private void btnImages_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImagePage());
        }

        private void btnDatePicker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DatePickerPage());
        }

        private void btnBoxView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BoxViewPage());
        }

        private void btnApp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PokemonPage());
        }

        private void btnStackLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void btnGridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GirdLayoutPage());
        }

        private void btnAbsLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsouteLayoutPage());
        }

        private void btnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutPage());
        }

        private void btnFlexLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutPage());

        }

    }
}
