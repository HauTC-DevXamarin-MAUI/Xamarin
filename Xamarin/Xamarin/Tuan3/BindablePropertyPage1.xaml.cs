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
    public partial class BindablePropertyPage1 : ContentPage
    {
        public string MyDescription { get; set; } = "Truong COng Hau";
        public BindablePropertyPage1()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}