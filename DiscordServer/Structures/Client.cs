using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordServer.Structures
{
    public class Client
    {
        public string Password;
        public string Name;
        public string ID;

        public DateTime Registered;
        public List<Guid> Sessions;

        public List<Chat> Chats;

        //make constructor
        public Client(string name, string password)
        {
            this.Name = name;
            this.Password = Utils.CreateMD5(password);
            this.ID = Guid.NewGuid().ToString();
            this.Registered = DateTime.Now;
            this.Sessions = new List<Guid>();
            this.Chats = new List<Chat>();
        }

        public bool SendLogin()
        {

        }

        public void SendMessage(Client client, string message)
        {
            if (Chats.Any(x => x.Clients.Contains(client)))
            {
                Chats.First(x => x.Clients.Contains(client)).SendMessage(message);
            }
            else
            {
                Chats.Add(new Chat(ChatType.PRIVATE, new List<Client>() { this, client }));
                Chats.First(x => x.Clients.Contains(client)).SendMessage(message);
            }
        }

    }
}
