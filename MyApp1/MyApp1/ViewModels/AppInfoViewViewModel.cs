using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class AppInfoViewViewModel : BindableBase
    {
        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
        public AppInfoViewViewModel()
        {
            var appName = AppInfo.Name;
            // Package Name/Application Identifier (com.microsoft.testapp)
            var packageName = AppInfo.PackageName;
            // Application Version (1.0.0)
            var version = AppInfo.VersionString;
            // Application Build Number (1)
            var build = AppInfo.BuildString;

            _status = "App Name: " + appName + "PackageName: " + packageName + "Version: " + version + "Build: " + build;
        }
        private DelegateCommand _openCommand;
        public DelegateCommand Opencommand =>
            _openCommand ?? (_openCommand = new DelegateCommand(ExecuteOpencommand, CanExecuteOpencommand));

        void ExecuteOpencommand()
        {
            AppInfo.ShowSettingsUI();
        }

        bool CanExecuteOpencommand()
        {
            return true;
        }
    }
}
