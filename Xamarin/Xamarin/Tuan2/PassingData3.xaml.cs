using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Tuan2;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassingData3 : ContentPage
    {
        public PassingData3()
        {
            InitializeComponent();
            lblMyname.Text = $"Xin chào {Application.Current.Properties["Name"].ToString()} đến với Xamarin Forms";
        }
    }
}