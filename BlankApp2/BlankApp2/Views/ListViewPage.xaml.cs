using BlankApp2.Models;
using Xamarin.Forms;

namespace BlankApp2.Views
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            lstViewMassage.ItemsSource = new Chat().GetMessages();
        }
    }
}
