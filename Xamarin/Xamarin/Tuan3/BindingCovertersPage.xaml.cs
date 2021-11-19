using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Tuan3.Converters;
using Xamarin.Tuan3.Models;

namespace Xamarin.Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingCovertersPage : ContentPage    {
        public ValuesViewModel valuesViewModel { get; set; }
        public BindingCovertersPage()
        {
            InitializeComponent();
            valuesViewModel = new ValuesViewModel();
        }

        private void btnSetValue_OnClicked(object sender, EventArgs e)
        {
            valuesViewModel.intInput = valuesViewModel.intInput + 10;
        }
    }
}