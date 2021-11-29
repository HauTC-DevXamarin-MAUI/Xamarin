using BlankApp2.Interfaces;
using BlankApp2.Services;
using BlankApp2.ViewModels;
using BlankApp2.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BlankApp2
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
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();

            containerRegistry.RegisterForNavigation<InjectionPage, InjectionPageViewModel>();
            containerRegistry.RegisterForNavigation<SingletonPage, SingletonPageViewModel>();

           
            containerRegistry.RegisterForNavigation<TransientPage, TransientPageViewModel>();

            containerRegistry.RegisterSingleton<ITheFirstService, TheFirstService>(); // single
            containerRegistry.Register<ITheSecondService, TheSecondService>(); // tránient
            containerRegistry.RegisterForNavigation<ListViewPage, ListViewPageViewModel>();
        }
    }
}
