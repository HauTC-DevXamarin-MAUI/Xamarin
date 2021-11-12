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
    public partial class PokemonDetailPage : ContentPage
    {
        private Pokemon _pokemon;
        public PokemonDetailPage(Pokemon pokemon)
        {
            InitializeComponent();

            _pokemon = pokemon;

            var pokedex = new Pokedex();
            var info = pokedex.GetPokemonInfo(pokemon);
            lblName.Text = info.Names.En;
            lblDesc.Text = info.PokedexEntries.OmegaRuby.En;
            lblHeight.Text = info.HeightEu;
            lblWeight.Text = info.WeightEu;
            imgPokemonDetail.Source = ImageSource.FromUri(new Uri(pokemon.ImageUrl));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var url = "http://www.pokemon.com/us/pokedex/"+ _pokemon.Slug;
            Device.OpenUri(new Uri(url));
        }
    }
}