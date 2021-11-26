using CommonServiceLocator;
using MyFirstAppp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppp.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            Bootstrap.Initialize();
        }

        public DependencyInjectionPageViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<DependencyInjectionPageViewModel>(); }
        }
    }
}
