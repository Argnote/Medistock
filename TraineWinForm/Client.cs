using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TraineWinForm
{

    class Client
    {
        private string message;
        public Client(string p_message)
        {
            string serveur = "192.168.121.54";
            Int32 port = 1302;
            NetworkStream networkStream = null;
            string demande = p_message;
            string reponse = null;
            

            try
            {
                TcpClient ClientTcp = new TcpClient(serveur, port);
                // on se connecte au service

                using (networkStream = ClientTcp.GetStream())
                {
                    using (StreamReader reader = new StreamReader(networkStream))
                    {
                        using (StreamWriter writer = new StreamWriter(networkStream))
                        {
                            // flux de sortie non bufferisé
                            writer.AutoFlush = true;
                            writer.WriteLine(demande);

                            reponse = reader.ReadLine();
                            //Console.Write(reponse + "\n");
                            message = reponse;
                            // on traite la réponse
                            //
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string getMessage()
        {
            return message;
        }
    }
}
