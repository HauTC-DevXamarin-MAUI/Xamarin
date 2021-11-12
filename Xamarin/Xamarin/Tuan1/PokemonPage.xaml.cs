using PokedexNET;
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
    public partial class PokemonPage : ContentPage
    {
        private Pokedex _pokedex;
        private Pokemon _pokemon;
        public PokemonPage()
        {
            InitializeComponent();
            _pokedex = new Pokedex();
        }
        private void btnFind_Clicked(object sender, EventArgs e)
        {
            var text = entryNumber.Text;
            if(int.TryParse(text, out int number))
            {
                _pokemon = _pokedex.GetPokemon(number);
                lblName.Text = _pokemon.Name;
                imgPokemon.Source = ImageSource.FromUri(new Uri(_pokemon.ImageUrl));
            }
        }
        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            if (_pokemon != null)
            {
                Navigation.PushAsync(new PokemonDetailPage(_pokemon));
            }
            else
            {
                DisplayAlert("Mess", "Lỗi rồi", "OK");
            }

        }
    }
}