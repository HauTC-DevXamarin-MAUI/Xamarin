using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;

namespace MyApp1.ViewModels
{
    public class ConnectivityViewViewModel : BindableBase
    {
        private string _status = "abc";
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
        public ConnectivityViewViewModel()
        {
            _status = "Network Access: " + Connectivity.NetworkAccess + 
                " Profile: " + Connectivity.ConnectionProfiles;
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            //_status = "Network Access: " + e.NetworkAccess + " Profile: " + e.ConnectionProfiles;
        }
    }
}
