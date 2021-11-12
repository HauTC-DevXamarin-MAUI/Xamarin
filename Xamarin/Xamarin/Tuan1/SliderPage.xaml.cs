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
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();            
        }

        private void sldRotating_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valueSldRotation = sldRotating.Value;
            lblRotating.RotateTo(valueSldRotation);
            lblDisplay.Text = valueSldRotation.ToString();
            if(valueSldRotation >= 120)
            {
                lblRotating.TextColor = Color.Red;
            }
            else if(valueSldRotation>=240)
            {
                lblRotating.TextColor = Color.Blue;
            }
            else
            {
                lblRotating.TextColor = Color.Orange;
            }    
        }
    }
}