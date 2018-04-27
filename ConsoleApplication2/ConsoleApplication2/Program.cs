using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse("192.168.1.108"),80);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                client.Connect(ipserver);
                Console.WriteLine(ipserver.ToString() + " is opened.");
                client.Close();
            }
            catch
            {
                Console.WriteLine(ipserver.ToString() + "is closed.");
            }
        }
    }
}
