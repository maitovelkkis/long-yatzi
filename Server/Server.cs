using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Server
    {
        internal SqlConnection cnn;
        internal void StartServer()
        {
            string connetionString;
            connetionString = @"Data Source=DESKTOP-IIR9L26\SQLEXPRESS01;Initial Catalog=LongYatzi;User ID=mahtiantti;Password=123;Trusted_Connection=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.WriteLine("Connection Open  !");
            string register = "/register";
            string login = "/login";
            string throwDice = "/throw";
            // Get Host IP Address that is used to establish a connection  
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
            // If a host has multiple addresses, you will get a list of addresses  
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);


            try
            {
                // Create a Socket that will use Tcp protocol      
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method  
                listener.Bind(localEndPoint);
                // Specify how many requests a Socket can listen before it gives Server busy response.  
                // We will listen 10 requests at a time  
                listener.Listen(10);
                while (true)
                {

                    Console.WriteLine("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    // Incoming data from the client.    
                    string data = null;
                    byte[] bytes = null;

                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("request received : {0}", data);
                    if (data.StartsWith(register))
                    {
                        string command = register;
                        data = data.Substring(command.Length);
                        Register("John", "123");
                    }
                    if (data.StartsWith(login))
                    {
                        string command = register;
                        data = data.Substring(command.Length);
                    }


                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    handler.Send(msg);
                }
                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Register(string _username, string _password)
        {
            cnn.CreateCommand();
        }
    }
}
