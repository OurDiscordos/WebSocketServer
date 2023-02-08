using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordServer.Structures
{
    public class Chat
    {
        public static List<Chat> Chats;

        public string Name;
        public string ID;
        public List<Client> Clients;
        public List<Message> Messages;
        public ChatType ChatType;

        public Chat(ChatType chatType = ChatType.PRIVATE, List<Client> clients = null)
        {
            if (chatType == ChatType.PRIVATE)
                if (Chats.Any(x => x.Clients.Contains(clients[0])) || Chats.Any(x => x.Clients.Contains(clients[1])))
                    return;
            this.ID = Guid.NewGuid().ToString();
            this.Clients = new List<Client>();
            this.Messages = new List<Message>();
            this.ChatType = chatType;

        }

        public void SendMessage(string message)
        {
            Messages.Add(new Message(message));
        }
    }

    public class Message
    {
        public string MessageText;
        public DateTime Time;
        public Client Author;
        
        public Message(string message)
        {
            this.MessageText = message;
            this.Time = DateTime.Now;
        }
    }

    public enum ChatType
    {
        PRIVATE,GROUP
    }
}
