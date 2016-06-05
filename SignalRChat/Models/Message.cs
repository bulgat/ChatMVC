using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string user { get; set; }
        public string message { get; set; }
    }
}