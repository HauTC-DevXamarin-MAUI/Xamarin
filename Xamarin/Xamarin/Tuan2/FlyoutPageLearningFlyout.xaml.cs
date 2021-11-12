using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageLearningFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPageLearningFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPageLearningFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPageLearningFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPageLearningFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPageLearningFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPageLearningFlyoutMenuItem>(new[]
                {
                    new FlyoutPageLearningFlyoutMenuItem { Id = 0, Title = "FirstPage",IconSource="home.png", TargetType=typeof(Page1)},
                    new FlyoutPageLearningFlyoutMenuItem { Id = 1, Title = "RootPage",IconSource="cart.png" , TargetType=typeof(RootPage)},
                    new FlyoutPageLearningFlyoutMenuItem { Id = 2, Title = "TabbedPage" ,IconSource="history.png" ,TargetType=typeof(TabbedPageLearning)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}