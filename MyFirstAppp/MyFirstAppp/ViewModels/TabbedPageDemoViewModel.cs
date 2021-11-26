using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppp.ViewModels
{
    public class TabbedPageDemoViewModel : BindableBase, IActiveAware
    {

        public TabbedPageDemoViewModel()
        {
            
        }
        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set 
            {
                SetProperty(ref _isActive, value,RaiseIsActiveChanged); 
            }
        }

        public event EventHandler IsActiveChanged;
        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
