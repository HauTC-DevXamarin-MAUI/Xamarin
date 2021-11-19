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
    public partial class BindablePropertyPage : ContentView
    {
        public static readonly BindableProperty TitleTextProperty =
            BindableProperty.Create(nameof(TitleText),
                typeof(string),
                typeof(BindablePropertyPage),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BindablePropertyPage)bindable;
            control.lblTitle.Text = newValue?.ToString();
        }

        public string TitleText 
        { 
            get { return base.GetValue(TitleTextProperty)?.ToString(); } 
            set { base.SetValue(TitleTextProperty, value); } 
        }


        public static readonly BindableProperty DescriptionTextProperty =
           BindableProperty.Create(nameof(TitleText),
               typeof(string),
               typeof(BindablePropertyPage),
               defaultValue: string.Empty,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: DescriptionTextPropertyChanged);

        private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BindablePropertyPage)bindable;
            control.lblDesciption.Text = newValue?.ToString();
        }

        public string DescriptionText
        {
            get { return base.GetValue(DescriptionTextProperty)?.ToString(); }
            set { base.SetValue(DescriptionTextProperty, value); }
        }
        public BindablePropertyPage()
        {
            InitializeComponent();
        }
    }
}