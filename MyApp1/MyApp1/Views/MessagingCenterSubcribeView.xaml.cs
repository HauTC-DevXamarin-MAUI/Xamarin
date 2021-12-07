using Xamarin.Forms;

namespace MyApp1.Views
{
    public partial class MessagingCenterSubcribeView : ContentPage
    {
        public MessagingCenterSubcribeView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MessagingCenterSendView, string>(this, "sendingMessage", (sender, message) =>
            {
                lblMess.Text = message;
            });
        }
    }
}
