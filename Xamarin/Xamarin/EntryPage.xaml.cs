using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }


        private void entryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblDisplay.Text = entryName.Text;
        }

        private void entryName_Completed(object sender, EventArgs e)
        {
            edtName.Text = lblDisplay.Text;
        }
    }
}