using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankApp2.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigatedAware, IInitializeAsync
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public ViewAViewModel()
        {
            Title = "View A của Hậu";
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
