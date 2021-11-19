using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : ContentPage
    {
        private MyName _myName;
        public RootPage()
        {
            InitializeComponent();
        }

        private void btnNextFirstPage_OnClicked(object sender, EventArgs e)
        {
            //FirstPage
            var page = new Page1();
            Navigation.PushAsync(page);

            NavigationPage.SetHasNavigationBar(page, false);
        }

        private void btnNextSecondPage_OnClicked(object sender, EventArgs e)
        {
            var page2 = new SecondPage();
            Navigation.PushAsync(page2);
        }

        private void btnPassingData_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PassingData1("Passing Data", "Passing Data Success"));
            //Navigation.PushAsync(new Page1());
        }

        async void btnUseBindingContext_OnClicked(object sender, EventArgs e)
        {
            _myName = new MyName()
            {
                Name = "Cong Hau",
                Age = 21,
            };
            var page = new PassingData2();
            page.BindingContext = _myName;

            Navigation.PushAsync(page);

            
        }

        private void btnPassingData3_OnClicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = entryName.Text;

            Navigation.PushAsync(new PassingData3());
        }

        private void masterDetailPage_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlyoutPageLearning());
        }

        private void btnTabbedPage_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPageLearning());
        }

        private void btnExplicitStyle_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExplicitStylePage());
        }

        private void btnImplicitAndGlobal_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImplicitStyleAndGlobalStylePage());

        }

        private void btnStyleInheritance_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StyleInheritancePage());
        }

        private void btnDynamicStyle_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicTypePage());
        }

        private void btnDeviceStyle_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceStylePage());

        }

        private void btnCSS_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CSSPage());
        }

        private void btnTriggers_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TriggersPage());
        }

        private void btnAttach_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AttachBehavior());

        }

        private void btnFormsBehacior_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XamarinFormsBehaviors());
        }

        private void btnEventToCommandBehavior_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewBehavior());

        }
    }
}