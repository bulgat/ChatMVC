using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SignalRChat.Models;

namespace SignalRChat
{
    public class MessageContext:DbContext
    {
        public MessageContext() : base("DBConnection")
        {

        }
        public DbSet<Message> Messages { get; set; }

    }
}