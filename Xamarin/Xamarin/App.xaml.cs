using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Tuan2;
using Xamarin.Tuan3;
using Xamarin.Tuan4.View;

namespace Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new ListViewBehavior();
            MainPage = new NavigationPage(new Tuan4.View.MyPage());
        } 

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
