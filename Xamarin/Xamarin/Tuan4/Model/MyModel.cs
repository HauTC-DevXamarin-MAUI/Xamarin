using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin.Tuan4.Model
{
    public class Item
    {
        public int Data { get; set; }
    }
    public class MyModel
    {
        public MyModel()
        {
            Items = new ObservableCollection<Item>();
        }
        public ObservableCollection<Item> Items { get; set; }
    }
}
