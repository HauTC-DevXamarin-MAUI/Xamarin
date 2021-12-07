using MyApp1.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.Interfaces
{
    public interface IMakeUpApi
    {
        //// Cách 1
        [Get("/api/v1/products.json?brand=maybelline")]
        Task<List<MakeUp>> GetMakeUps();

        // Cách 2
        //[Get("/api/v1/products.json")]
        //Task<HttpResponseMessage> GetMakeUps();

    }
}
