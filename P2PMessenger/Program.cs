using System;
using System.Net;

namespace P2PMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetBroadCastIP(IPAddress.Parse("localhost"), ));
            Console.ReadLine();
        }

        static IPAddress GetBroadCastIP(IPAddress host, IPAddress mask)
        {
            byte[] broadcastIPBytes = new byte[4];
            byte[] hostBytes = host.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            for (int i = 0; i < 4; i++)
            {
                broadcastIPBytes[i] = (byte)(hostBytes[i] | (byte)~maskBytes[i]);
            }
            return new IPAddress(broadcastIPBytes);
        }
    }
}
