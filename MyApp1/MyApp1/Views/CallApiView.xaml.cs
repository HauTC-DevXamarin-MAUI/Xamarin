using MyApp1.Interfaces;
using MyApp1.Models;
using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApp1.Views
{
    public partial class CallApiView : ContentPage
    {
        private bool initialized = false;
        public ObservableCollection<TodoItem> TodoItems { get; set; } = new
            ObservableCollection<TodoItem>();

        private readonly ITodoServer todoServer =
            RestService.For<ITodoServer>("https://jsonplaceholder.typicode.com");
        public CallApiView()
        {
            InitializeComponent();
            BindingContext = this;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (!initialized)
            {
                await GetTodoItems();
                initialized = true;
            }
        }

        private async Task GetTodoItems()
        {
            var items = await todoServer.GetTodoItems();

            foreach (var item in items)
            {
                TodoItems.Add(item);
            }

            //var todoItem = await todoServer.GetTodoItems(1);
            //TodoItems.Add(todoItem);



            //var savedTodoItem = await todoServer.SaveTodoItem(new TodoItem 
            //{ 
            //    Complete = true,
            //    Title ="Truong Cong Hau",
            //    UserId =1,
            //});
            //TodoItems.Add(savedTodoItem);

        }
    }
}
