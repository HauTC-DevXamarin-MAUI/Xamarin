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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Tuan3;

[assembly: ExportRenderer(typeof(MyRadioButton), typeof(Xamarin.Droid.RadioButtonRenderer))]
namespace Xamarin.Droid
{


#pragma warning disable CS0618 // Type or member is obsolete
    public class RadioButtonRenderer : ViewRenderer<MyRadioButton, global::Android.Widget.RadioButton>
    {
        public RadioButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyRadioButton> e)
        {
            base.OnElementChanged(e);
            // ton tai
            if (e.OldElement != null)
            {
                e.OldElement.PropertyChanged -= OldElementPropertyChanged; ;
            }
            // chua ton tai -> khoi tao
            if (Control == null)
            {
                var radioButton = new global::Android.Widget.RadioButton(Context);
                SetNativeControl(radioButton);
            }
            // set value
            Control.Text = e.NewElement.Text;
            Control.TextSize = 20;
            Control.Checked = e.NewElement.IsChecked;
            Control.CheckedChange += OnCheckedChange;
            Element.PropertyChanged += OldElementPropertyChanged;
        }

        private void OldElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Checked":
                    Control.Checked = Element.IsChecked;
                    break;

                case "Text":
                    Control.Text = Element.Text;
                    break;

                default:
                    break;
            }
        }

        private void OnCheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            var view = Element;
            if (view != null)
            {
                view.IsChecked = e.IsChecked;
                view.OnCheckedChanged(e.IsChecked);
            }
        }

    }
#pragma warning restore CS0618 // Type or member is obsolete
}