using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
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
using Xamarin.Tuan3.Effects;
using Button = Xamarin.Forms.Button;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(ButtonEffectAndroid), "MyButtonEffect")]
namespace Xamarin.Droid
{
    public class ButtonEffectAndroid : PlatformEffect
    {
        public ButtonEffectAndroid()
        {

        }
        protected override void OnAttached()
        {
            if (Control != null)
            {
                
                var effect = (MyButtonEffect)Element.Effects.FirstOrDefault(e => e is MyButtonEffect);
                if(effect!= null)
                {
                    double borderWidth = effect.BorderWidth;
                    global::Android.Graphics.Color color = effect.ColorBgr.ToAndroid();

                     var roundableShape = new GradientDrawable();
                    //roundableShape.SetShape(ShapeType.Rectangle); 
                    roundableShape.SetStroke((int)borderWidth, color);
                    roundableShape.SetColor(color);
                    //roundableShape.SetCornerRadius(Element.BorderRadius * Resources.DisplayMetrics.Density); 
                    Control.Background = roundableShape;
                    //Control.TransformationMethod = null; 
                    //Control.Elevation = 0; 
                }


            }
            else
                return;
        }
        protected override void OnDetached()
        {
            
        }
    }
}