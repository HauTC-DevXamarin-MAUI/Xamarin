using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class EmailViewViewModel : BindableBase
    {
        private string _recipients;
        public string Recipients
        {
            get { return _recipients; }
            set { SetProperty(ref _recipients, value); }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { SetProperty(ref _subject, value); }
        }
        private string _body;
        public string Body
        {
            get { return _body; }
            set { SetProperty(ref _body, value); }
        }
        public EmailViewViewModel()
        {

        }

        public async Task SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,
                };
                await Email.ComposeAsync(message);
            }
            catch (Exception)
            {

            }
        }
        private DelegateCommand _sendCommand;
        public DelegateCommand SendCommand =>
            _sendCommand ?? (_sendCommand = new DelegateCommand(ExecuteSendCommand));

        async void ExecuteSendCommand()
        {
            List<string> recipients = new List<string>
            {
                _recipients
            };
            await SendEmail(_subject, _body, recipients);
        }
    }
}
