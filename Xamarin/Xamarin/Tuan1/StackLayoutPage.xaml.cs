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
    public partial class StackLayout : ContentPage
    {
        public StackLayout()
        {
            InitializeComponent();
        }

        private void btnHorStart_Clicked(object sender, EventArgs e)
        {
            lblTarget.HorizontalOptions = LayoutOptions.Start;
        }

        private void btnHorCenter_Clicked(object sender, EventArgs e)
        {
            lblTarget.HorizontalOptions = LayoutOptions.Center;
        }

        private void btnHorEnd_Clicked(object sender, EventArgs e)
        {
            lblTarget.HorizontalOptions = LayoutOptions.End;
        }

        private void btnHorFill_Clicked(object sender, EventArgs e)
        {
            lblTarget.HorizontalOptions = LayoutOptions.Fill;
        }

        private void btnVerStart_Clicked(object sender, EventArgs e)
        {
            lblTarget.VerticalOptions = LayoutOptions.Start;
        }

        private void btnVerCenter_Clicked(object sender, EventArgs e)
        {
            lblTarget.VerticalOptions = LayoutOptions.Center;
        }

        private void btnVerEnd_Clicked(object sender, EventArgs e)
        {
            lblTarget.VerticalOptions = LayoutOptions.End;
        }

        private void btnVerFill_Clicked(object sender, EventArgs e)
        {
            lblTarget.VerticalOptions = LayoutOptions.Fill;
        }
    }
}