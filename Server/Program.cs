using System;
using System.Data;
using LongYatzi;

namespace Server
{
    public class Program
    {
        public static void Main()
        {
            Server server = new Server();
            server.StartServer();
        }
    }
}
