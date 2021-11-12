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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }        
        private void Button_OnClicked_RemoveAll(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}