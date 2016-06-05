using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRChat.Models;
using System.Runtime.Remoting.Contexts;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);

            // Добавляем сообщение чата в базу ORM Entite framework.
            saveDB_ORM(name, message);
            
        }
        public void Inner(string name)
        {

            Clients.All.addNewUser(name);

            // Добавляем сообщение чата в базу ORM Entite framework.
            saveDB_ORM(name, "вошел пользователь");

        }

        public void Out(string name)
        {
            Clients.All.outUser(name);

            // Добавляем сообщение чата в базу ORM Entite framework.
            //saveDB_ORM(name, "вышел пользователь");
        }

        // Добавляем сообщение чата в базу ORM Entite framework.
        public void saveDB_ORM(string name, string message)
        {
            DataMessageContext context = new DataMessageContext();

            MessageTable mess = new MessageTable()
            {
                User = name.ToString(),
                DateTime = DateTime.Now.ToString(),
                Message = message.ToString()
            };

            context.MessageTable.Add(mess);

            context.SaveChanges();

        }
    }
}