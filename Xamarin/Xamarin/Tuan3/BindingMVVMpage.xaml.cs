using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Tuan3.Models;

namespace Xamarin.Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingMVVMpage : ContentPage
    {
        public BindingMVVMpage()
        {
            InitializeComponent();
        }

        //private void btnSubmit_OnClicked(object sender, EventArgs e)
        //{
        //    var itemViewModel = (ItemInfoViewModel)BindingContext;

        //    lblMessage.Text = "Save Item: Name: " + itemViewModel.ItemName + " , " + "Price: " + itemViewModel.Price;
        //}
    }
}