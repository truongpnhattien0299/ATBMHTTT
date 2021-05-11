using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using Client;
namespace Server
{
    class Server
    {
        static string ADDRESS = "127.0.0.1";
        static int PORT = 3000;
        static IPEndPoint IP = null;
        static Socket listener = null, client = null;
        static ArrayList listSocket = null, arrData = null; // danh sach socket cua client
        static Data dataClient = null;
        static void Main(string[] args)
        {
            Start();
            //Connect();
        }

        static void Start()
        {
            IP = new IPEndPoint(IPAddress.Parse(ADDRESS), PORT);
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            arrData = new ArrayList();

            try
            {
                listener.Bind(IP);
                Console.WriteLine($"Socket Bind to {IP} Waiting for connect");
                listener.Listen(10);
                Thread connect = new Thread(Connect);
                connect.Start();
            }
            catch
            {
                IP = new IPEndPoint(IPAddress.Parse(ADDRESS), PORT);
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
        }
        static void Connect()
        {
            listSocket = new ArrayList();
            while (true)
            {
                try
                {
                    client = listener.Accept();
                    listSocket.Add(client);
                    Console.WriteLine($"{client.RemoteEndPoint} Connected");

                    //if (arrData.Count > 0)
                        client.Send(Object2ByteArray(arrData));

                    Thread threadReceive = new Thread(Receive);
                    threadReceive.IsBackground = true;
                    threadReceive.Start(client);
                }
                catch
                {
                    Console.WriteLine("Loi connect");
                    return;
                }
            }
        }

        //static void Send(Socket client)
        //{
        //    client.Send(Object2ByteArray(dataClient));
        //}

        static void Receive(object obj)
        {
            Socket clientSocket = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    clientSocket.Receive(data);
                    dataClient = (Data)ByteArray2Object(data);
                    arrData.Add(dataClient);
                    Console.WriteLine($"{dataClient.text}");

                    //Send(clientSocket);
                    foreach (Socket item in listSocket)
                    {
                        item.Send(Object2ByteArray(dataClient));
                    }
                }
            }
            catch
            {

            }
        }

        //static void Close()
        //{
        //    client.Close();
        //}

        static byte[] Object2ByteArray(object obj)
        {
            //MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream, obj);
                return memoryStream.ToArray();
            }
        }

        static object ByteArray2Object(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                return formatter.Deserialize(memoryStream);
            }
        }
    }
}
