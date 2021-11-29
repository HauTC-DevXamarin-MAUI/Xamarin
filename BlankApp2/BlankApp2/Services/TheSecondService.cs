using BlankApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp2.Services
{
    public class TheSecondService : ITheSecondService
    {
            public List<int> ListCustomer { get; set; }
            public TheSecondService()
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
