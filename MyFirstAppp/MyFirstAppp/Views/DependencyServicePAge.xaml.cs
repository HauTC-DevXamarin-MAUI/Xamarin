using MyFirstAppp.Interfaces;
using MyFirstAppp.Models;
using Xamarin.Forms;

namespace MyFirstAppp.Views
{
    public partial class DependencyServicePAge : ContentPage
    {
        public DependencyServicePAge()
        {
            InitializeComponent();

            lblOriention.Text = 
                DependencyService.Get<IDeviceOrientation>().GetOrientation().ToString();
        }

        private void Button_OnClicked(object sender, System.EventArgs e)
        {
            
        }
    }
}
