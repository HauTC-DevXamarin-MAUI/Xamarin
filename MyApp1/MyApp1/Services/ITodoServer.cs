using MyApp1.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.Interfaces
{
    public interface ITodoServer
    {
        [Get("/todos")]
        Task<TodoItem[]> GetTodoItems();

        ////
        [Get("/todos/{id}")]
        Task<TodoItem> GetTodoItems(int id);

        //
        [Post("/todos")]
        Task<TodoItem> SaveTodoItem([Body]TodoItem item);
    }
}
