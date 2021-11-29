using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp2.Models
{
    public class Chat
    {
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Massage { get; set; }
        public DateTime DataSent { get; set; }
        public string ImgUrl { get; set; }
        public string Status { get; set; }

        public List<Chat> GetMessages()
        {
            List<Chat> messages = new List<Chat>()
            {
                new Chat()
                {FromUser="Hau",ToUser="Nhut",Massage="Hi Nhut!",
                    ImgUrl="dog.jpg",
                    DataSent = DateTime.Now,
                    Status = "Received"
                },

                new Chat()
                {FromUser="Nhut",ToUser="Hau",Massage="Hello Hau!",
                    ImgUrl="cat.jpg",
                    DataSent = DateTime.Now,
                    Status = "Sent"
                },

                new Chat()
                {FromUser="Hau",ToUser="Nhut",Massage="Long time no see ",
                    ImgUrl="dog.jpg",
                    DataSent = DateTime.Now,
                    Status = "Received"
                },

                new Chat()
                {FromUser="Nhut",ToUser="Hau",Massage="Yes, long time....",
                    ImgUrl="cat.jpg",
                    DataSent = DateTime.Now,
                    Status = "Sent"
                },
            };
            return messages;
        }
            
    }
}
