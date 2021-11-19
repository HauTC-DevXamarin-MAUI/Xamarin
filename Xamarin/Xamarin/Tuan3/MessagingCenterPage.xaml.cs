using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagingCenterPage : ContentPage
    {
        public ObservableCollection<string> MessagingItems { get; set; } = new ObservableCollection<string>();

        public MessagingCenterPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        // Subscribe 
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, datetime) =>
            {
                MessagingItems.Add($"Message received at {datetime}");
            });
        }

        // Go to page
        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SendMessagingCenterPage());
        }
    }
}
