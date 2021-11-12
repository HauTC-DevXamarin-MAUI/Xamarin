using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxViewPage : ContentPage
    {
        Dictionary<string, Color> NamesToColor = new Dictionary<string, Color>
        {
            {"Aqua",Color.Aqua},{"Black",Color.Black},{"White",Color.White},
            {"Red",Color.Red},{"Gray",Color.Gray},{"Green",Color.Green},
            {"Lime",Color.Lime},{"Maroon",Color.Maroon},{"Navy",Color.Navy},
            {"Olive",Color.Olive},{"AliceBlue",Color.AliceBlue},{"DarkBlue",Color.DarkBlue},
            {"Cyan",Color.Cyan},{"Linen",Color.Linen},{"LawnGreen",Color.LawnGreen}
        };
        public BoxViewPage()
        {
            InitializeComponent();
            InitPicker();
        }
        void InitPicker()
        {
            foreach (string color in NamesToColor.Keys)
            {
                pickerColor.Items.Add(color);
            }
            pickerColor.SelectedIndexChanged += (s, e) => { 
                if(pickerColor.SelectedIndex == -1)
                {
                    boxViewColor.Color = Color.Default;
                }
                else
                {
                    string colorTemp = pickerColor.SelectedItem.ToString();
                    boxViewColor.Color = NamesToColor[colorTemp];
                }
            };
        }
    }
}