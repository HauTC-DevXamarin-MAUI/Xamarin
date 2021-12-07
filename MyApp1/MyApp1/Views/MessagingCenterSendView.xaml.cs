using Xamarin.Forms;

namespace MyApp1.Views
{
    public partial class MessagingCenterSendView : ContentPage
    {
        public MessagingCenterSendView()
        {
            InitializeComponent();
        }

        private void btnSendMessage_OnClicked(object sender, System.EventArgs e)
        {
            var mess = msgEntry.Text;
            MessagingCenter.Send<MessagingCenterSendView, string>(this, "sendingMessage", mess);
        }
    }
}
