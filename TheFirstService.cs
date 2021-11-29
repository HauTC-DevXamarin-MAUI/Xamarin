using System;

public class TheFirstService
{
	public TheFirstService()
	{

         public class CustomService : ICustomService
    {
        public List<int> ListCustomer { get; set; }
        public CustomService()
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
}
