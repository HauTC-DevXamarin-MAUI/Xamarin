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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(Xamarin.Tuan3.Models.BorderEntry), typeof(Xamarin.Droid.BoderEntry))]
namespace Xamarin.Droid
{
    public class BoderEntry : EntryRenderer
    {
        public BoderEntry(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var customEntry = e.NewElement as Xamarin.Tuan3.Models.BorderEntry;
                var gradientDrawable = new GradientDrawable();
                //lấy value từ BorderEntry và set.
                gradientDrawable.SetCornerRadius(customEntry.BorderRadius);
                gradientDrawable.SetStroke(3, global::Android.Graphics.Color.Green);
                gradientDrawable.SetColor(global::Android.Graphics.Color.LightGray);
                Control.SetBackground(gradientDrawable);
                Control.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
            }
        }
    }
}