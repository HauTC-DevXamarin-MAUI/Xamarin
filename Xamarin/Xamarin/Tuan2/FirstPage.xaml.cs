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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnNextSecondPage_OnClicked(object sender, EventArgs e)
        {
            var page2 = new SecondPage();
            Navigation.PushAsync(page2);

            NavigationPage.SetHasBackButton(page2, false);
        }

        private void Button_OnClicked_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}