using MyApp1.Interfaces;
using Refit;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MyApp1.Views
{
    public partial class ApiFirstView : ContentPage
    {
        public ApiFirstView()
        {
            InitializeComponent();
        }

        async void Button_OnClicked(object sender, System.EventArgs e)
        {
            await CallApi();

        }

        //Cách 1
        async Task CallApi()
        {
            var api = RestService.For<IMakeUpApi>
                ("http://makeup-api.herokuapp.com");

            Loading.IsRunning = true;
            var response = await api.GetMakeUps();
            Loading.IsRunning = false;

            ListViewMakeUp.ItemsSource = response;
        }

        //Cách 2
        //async Task CallApi()
        //{
        //    var api = RestService.For<IMakeUpApi>("https://makeup-api.herokuapp.com");
        //    Loading.IsRunning = true;
        //    var response = await api.GetMakeUps();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        var makeUps =
        //            JsonSerializer.Deserialize<List<MakeUp>>
        //            (responseContent, new JsonSerializerOptions()
        //            { PropertyNameCaseInsensitive = true });
        //        ListViewMakeUp.ItemsSource = makeUps;
        //    }
        //    Loading.IsRunning = false;
        //}
    }
}
