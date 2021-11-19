using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Content.Res.Resources;

namespace Xamarin.Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TriggersPage : ContentPage
    {
        public TriggersPage()
        {
            InitializeComponent();
        }

        private void OnpickerThemeSelectionChanged(object sender, EventArgs e)
        {
            //Picker picker = sender as Picker;
            //Theme theme = (Theme)picker.SelectedItem;

            //ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            //if (mergedDictionaries != null)
            //{
            //    mergedDictionaries.Clear();

            //    switch (theme)
            //    {
            //        case Theme.DarkTheme:
            //            mergedDictionaries.Add(new DarkTheme());
            //            break;
            //        case Theme.LightTheme:
            //        default:
            //            mergedDictionaries.Add(new LightTheme());
            //            break;
            //    }
            //}
        }
    }
}