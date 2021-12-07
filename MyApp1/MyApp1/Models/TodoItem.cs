using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp1.Models
{
    public class TodoItem
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
    }
}
