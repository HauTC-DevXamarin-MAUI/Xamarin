using BlankApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp2.Services
{
    class TheFirstService : ITheFirstService
    {
        public List<int> ListCustomer { get; set; }
        public TheFirstService()
        {
            ListCustomer = GetListCustomer();
        }
        public List<int> GetListCustomer()
        {
            List<int> listNumber = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                listNumber.Add(rd.Next(1, 100));
            }
            return listNumber;
        }
    }
}
