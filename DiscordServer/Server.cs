using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonWebsocket;

namespace DiscordServer
{
    public class Server
    {
        public static WatsonWsServer server;
        
        public Server()
        {
            server = new WatsonWsServer();
            server.Start();
            Console.WriteLine("Server started");
        }
    }
}
