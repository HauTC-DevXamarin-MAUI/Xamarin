using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Content.Res.Resources;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TriggersPage : ContentPage
    {
        public TriggersPage()
        {
            InitializeComponent();
        }

        private void OnpickerThemeSelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}