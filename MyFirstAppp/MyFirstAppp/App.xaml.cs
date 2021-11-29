using MyFirstAppp.ViewModels;
using MyFirstAppp.Views;
using Prism;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Reflection;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace MyFirstAppp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }
        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();

        //    ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
        //    {
        //        var prefix = viewType.FullName.Replace(".Pages.", ".PageModels.");

        //        var viewAssemlyName = viewType.GetTypeInfo().Assembly.FullName;

        //        var viewModelName = $"{prefix}ViewModel, {viewAssemlyName}";

        //        return Type.GetType(viewModelName);
        //    });
        //}

        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();

        //    ViewModelLocationProvider.Register<MainPage,CustomMainPageViewModel>();
        //}
        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
            //await NavigationService.NavigateAsync("NavigationPage/ViewA");
            //++++++++++++++++++++++++++++++++++++++++


            //var result = await NavigationService.NavigateAsync("NavigationPage/MainPage");

            var result = await NavigationService.NavigateAsync("NavigationPage/ListViewDemo");
            //var result = await NavigationService.NavigateAsync("TabbedPage/ViewB");

            //var result = await NavigationService.NavigateAsync("TabbedPage?selectedTab=ViewB");
            //var result = await NavigationService.NavigateAsync($"TabbedPage ?{ KnownNavigationParameters.SelectedTab}= ViewB");

            //var result = await NavigationService.NavigateAsync("MasterDetailPageDemo/NavigationPage/TabbedPageDemo");

            //var result = await NavigationService.NavigateAsync("DependencyServicePAge");


            //var result = await NavigationService.NavigateAsync("DependencyInjectionPage");




        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            ////mac dinh
            //containerRegistry.RegisterForNavigation<NavigationPage>(); 

            ////dang ky khi khoi dong : MainPage
            //containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            //containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            //containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
            //containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>();
            //containerRegistry.RegisterForNavigation<ViewD, ViewDViewModel>();

            //++++++++++++++++++++++++++++++++++++++++
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB,ViewBViewModel>();
            containerRegistry.RegisterForNavigation<ViewC>();
            containerRegistry.RegisterForNavigation<ViewD>();

            containerRegistry.RegisterForNavigation<ListViewDemo, ListViewDemoViewModel>();
            containerRegistry.RegisterForNavigation<TabbedPageDemo, TabbedPageDemoViewModel>("TabbedPage");
            containerRegistry.RegisterForNavigation<DependencyServicePAge, DependencyServicePAgeViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailPageDemo, MasterDetailPageDemoViewModel>();
            containerRegistry.RegisterForNavigation<DependencyInjectionPage, DependencyInjectionPageViewModel>();
        }
    }
}
