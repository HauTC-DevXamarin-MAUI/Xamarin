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
    public partial class ButtonPage : ContentPage
    {
        private bool chkHandleClick = false;
        private int quantity = 1;
        public ButtonPage()
        {
            InitializeComponent();
        }
        
        private void btnButton_Clicked(object sender, EventArgs e)
        {
            if(chkHandleClick == false)
            {   
                btnButton.Text = "Đã nhấn " + quantity + " lần !";
                btnButton.CornerRadius = 20;
                quantity++;
                chkHandleClick = true;
            }
            else
            {
                btnButton.Text = "Đã nhấn " + quantity + " lần !";
                btnButton.CornerRadius = 0;
                quantity++;
                chkHandleClick = false;
            }
        }

        private void imgButton_Clicked(object sender, EventArgs e)
        {
            if(rdoDog.IsChecked)
            {
                imgButton.Source = "dog.jpg";
            }
            else if(rdoCat.IsChecked)
            {
                imgButton.Source = "cat.jpg";
            }
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string text = sbar.Text;
            if(text == "dog" || text =="Dog")
            {
                imgButton.Source = "dog.jpg";
            }
            else if (text == "cat" || text == "Cat")
            {
                imgButton.Source = "cat.jpg";
            }
            else
                DisplayAlert("Thông báo", text, "OK");
        }
    }
}