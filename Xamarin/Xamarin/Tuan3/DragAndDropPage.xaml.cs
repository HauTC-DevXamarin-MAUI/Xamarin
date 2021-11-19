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
    public partial class DragAndDropPage : ContentPage
    {
        public DragAndDropPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            BoxView boxview = (sender as Element)?.Parent as BoxView;
            e.Data.Properties.Add("Demo", boxview);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var box_view = e.Data.Properties["Demo"] as BoxView;
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = box_view;
        }
    }
}