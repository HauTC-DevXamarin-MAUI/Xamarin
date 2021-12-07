using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;

namespace MyApp1.Models
{
    public class MessageSentEvent : PubSubEvent<string>
    {
    }
}
