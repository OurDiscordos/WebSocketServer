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
        public WatsonWsServer server;
        
        public Server()
        {
            server = new WatsonWsServer();
            
            
        }
    }
}
