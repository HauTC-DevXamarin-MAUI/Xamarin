using MyApp1.ViewModels;
using MyApp1.Views;
using MyApp1.Views.XamarinEssential;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace MyApp1
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ApiFirstView, ApiFirstViewViewModel>();
            containerRegistry.RegisterForNavigation<CallApiView, CallApiViewViewModel>();
            containerRegistry.RegisterForNavigation<MessagingCenterSendView, MessagingCenterSendViewViewModel>();
            containerRegistry.RegisterForNavigation<MessagingCenterSubcribeView, MessagingCenterSubcribeViewViewModel>();

            containerRegistry.RegisterForNavigation<EventAggregatorView, EventAggregatorViewViewModel>();
            containerRegistry.RegisterForNavigation<EventAggregatorListView, EventAggregatorListViewViewModel>();
            containerRegistry.RegisterForNavigation<EventAggregatorA, EventAggregatorAViewModel>();
            containerRegistry.RegisterForNavigation<EventAggregatorB, EventAggregatorBViewModel>();



            containerRegistry.RegisterForNavigation<EssentialMainView, EssentialMainViewViewModel>();
            containerRegistry.RegisterForNavigation<AcclerometerView, AcclerometerViewViewModel>();
            containerRegistry.RegisterForNavigation<AppInfoView, AppInfoViewViewModel>();
            containerRegistry.RegisterForNavigation<BatteryView, BatteryViewViewModel>();
            containerRegistry.RegisterForNavigation<ConnectivityView, ConnectivityViewViewModel>();
            containerRegistry.RegisterForNavigation<DataTransferView, DataTransferViewViewModel>();
            containerRegistry.RegisterForNavigation<DeviceDisplayInformationView, DeviceDisplayInformationViewViewModel>();
            containerRegistry.RegisterForNavigation<DeviceInfoView, DeviceInfoViewViewModel>();
            containerRegistry.RegisterForNavigation<ClipboardView, ClipboardViewViewModel>();
            containerRegistry.RegisterForNavigation<EmailView, EmailViewViewModel>();
            containerRegistry.RegisterForNavigation<FlashlightView, FlashlightViewViewModel>();
            containerRegistry.RegisterForNavigation<GeolocationView, GeolocationViewViewModel>();
            containerRegistry.RegisterForNavigation<PhoneDialerView, PhoneDialerViewViewModel>();
        }
    }
}
