using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Tuan3;

[assembly:ExportRenderer(typeof(MyRadioButton),typeof(RadioButtonRendererAndroid))]
namespace Xamarin.Droid
{
    public class RadioButtonRendererAndroid : RadioButtonRenderer
    {
        public RadioButtonRendererAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Forms.RadioButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);              
              
            }
        }

    }
}