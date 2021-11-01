using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }
        private void LoadHTML()
        {
            var localHTML = new HtmlWebViewSource();
            localHTML.Html = @"<html><body>
                                     <h1>Xamarin Web View</h1>
                                     <p>This is my first xamarin local html</p>
                               </body></html>";
            webView.Source = localHTML;
        }

        private void btnLocalHtml_Clicked(object sender, EventArgs e)
        {
            LoadHTML();
        }
    }
}