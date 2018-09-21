using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Single_Client_Server
{
    
    class ServerProgram
    {
        
        // decalring the byte[] array 
        static byte[] Buffer { get; set; }

        // declaring the socket 
        static Socket sck;

        static void Main(string[] args)
        {
            Console.WriteLine("Server started....");

            // initializaton of socket (provide Address, SocketType, and the Protocol which you want to use )

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket with and create the IPEndPoint (provide IP address , And Port Number)

            sck.Bind(new IPEndPoint(0, 1234));

            // listener i.e network listner  it will prvide connection between client and server
            // all the Ip address on Port number 100 will allow to make the connection between server /client
            sck.Listen(100);  // blocklog

            // make blocklog to wait for unavaiable to attempts to connects 
            Socket accepted = sck.Accept();

            // now initialize the Buffer by receiving  the accepted.SendBufferSize at one time
            Buffer = new byte[accepted.SendBufferSize];
            // now Buffer variable will hold the size of bytes received 

            // Now Begin the Receiving 
            int bytesRead = accepted.Receive(Buffer);

            // now start formatting 
            byte[] Formatted = new byte[bytesRead];
            // copy the buffer bytes into Formatted byte[]
            for (int i =0; i < bytesRead; i++)
            {
                Formatted[i] = Buffer[i];
            }

            // Write the Data onto the Console
            string StrData = Encoding.ASCII.GetString(Formatted);
            Console.Write(StrData + "\r\n");
           
            Console.Read();

            // close the socket
            sck.Close();
            accepted.Close();
        }
    }
}
