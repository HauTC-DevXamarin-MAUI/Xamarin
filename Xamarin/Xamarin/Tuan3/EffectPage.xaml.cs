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
    public partial class EffectPage : ContentPage
    {
        public EffectPage()
        {
            InitializeComponent();
            Button btn = new Button();
        }
    }
}