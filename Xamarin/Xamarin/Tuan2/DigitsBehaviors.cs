using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Xamarin.Tuan2
{
    class DigitsBehaviors: Behavior<Entry>
    {
        private const string digitRegex = @"^[0-9]+$";
        public static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly(
                "IsValid",
                typeof(bool),
                typeof(DigitsBehaviors),
                false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get
            {
                return (bool)this.GetValue(IsValidProperty);
            }
            set
            {
                this.SetValue(IsValidPropertyKey,value);
            }
        }
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += bindable_TextChanged;
        }

        private void bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry;
            //bool isValid;

            entry = (Entry)sender;
            //isValid = Regex.IsMatch(e.NewTextValue, digitRegex);
            this.IsValid = Regex.IsMatch(e.NewTextValue, digitRegex);

            //entry.TextColor = isValid ? Color.Default : Color.Red;
            entry.TextColor = this.IsValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= this.bindable_TextChanged;
        }
    }
}
