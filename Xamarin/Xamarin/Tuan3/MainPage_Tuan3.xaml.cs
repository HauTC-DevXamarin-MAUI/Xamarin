using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage_Tuan3 : ContentPage
    {
        public MainPage_Tuan3()
        {
            InitializeComponent();
        }

        private void btnCustomRederer_OnClicked(object sender, EventArgs e)
        {
            var page = new CustomRedererPage();
            Navigation.PushAsync(page);
        }

        private void btnEffect_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EffectPage());
        }

        private void btnDataBinding_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindingPage());
        }

        private void btnBindingMVVM_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingMVVMpage());
        }

        private void btnBindingConverter_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingCovertersPage());
        }

        private void btnBindableProperty_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindablePropertyPage1());

        }

        private void btnGestureRecognizers_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GestureRecognizersPage());
        }

        private void btnBindableProperty2_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindablePropertyPage2());
        }

        private void btnCommand_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CommandPage());
        }

        private void btnMessCenter_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MessagingCenterPage());
        }
    }
}