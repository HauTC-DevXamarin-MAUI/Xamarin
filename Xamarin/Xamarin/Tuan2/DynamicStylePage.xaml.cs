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
    public partial class DynamicTypePage : ContentPage
    {
        bool isClicked = true;
        public DynamicTypePage()
        {
            InitializeComponent();
        }

        private void btnDynamicResource_OnClicked(object sender, EventArgs e)
        {
            if(isClicked)
            {
                Resources["labelStyle"] = Resources["redStyle"];
                isClicked = false;
            }
            else
            {
                Resources["labelStyle"] = Resources["blueStyle"];
                isClicked = true;
            }
        }
    }
}