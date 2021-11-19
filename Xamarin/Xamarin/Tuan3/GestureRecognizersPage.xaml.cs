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
    public partial class GestureRecognizersPage : ContentPage
    {
        public GestureRecognizersPage()
        {
            InitializeComponent();
        }
        private bool isTapped = false;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            isTapped = !isTapped;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if(isTapped)
            {
                imageSender.Source = "dog.jpg";
            }
            else            
                imageSender.Source = "cat.jpg";
        }

        private void btnSwipeGesture_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwipeGesturePage());
        }

        private void btnDragDrop_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DragAndDropPage());

        }
    }
}