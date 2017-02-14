using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            #region my 2 way Client code
            //set up client
            TcpClient clientSocket = new TcpClient("localhost", 6789);
            Console.WriteLine($"Client started");

            Stream ns = clientSocket.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);

            while (true)
            {

                //send message
                string sendMsg = Console.ReadLine();
                sw.WriteLine(sendMsg);
                sw.AutoFlush = true;
                //receive message  
                string receivedMsg = sr.ReadLine();
                Console.WriteLine($"Client: {receivedMsg}");

            }
            #endregion


        }
    }
}
