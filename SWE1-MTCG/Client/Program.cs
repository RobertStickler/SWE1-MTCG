﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Client
{
    public class Program
    {
        public static void Main()
        {

            //Console.WriteLine("1...Start Battle");
            

            ClientFunctions conetction = new ClientFunctions();

            conetction.SocketConnection();
            return;
        }
        public static void PrintMenueOne()
        {
            Console.WriteLine("choose your action");
            Console.WriteLine("1...login");
            Console.WriteLine("2...register");
            Console.WriteLine("0...quit");

        }
        public static void PrintMenueTwo()
        {
            Console.WriteLine("choose your action");
            Console.WriteLine("3...Start a Battle");
            Console.WriteLine("4...Buy new Cards");
            Console.WriteLine("5...Look your Deck");
            Console.WriteLine("6...Show your Card Collection");
            Console.WriteLine("7...Trade for Coins");
            Console.WriteLine("8...Trade with other Player");
            Console.WriteLine("9...Edit your Deck");
            Console.WriteLine("10...Show Scoreboard");

            Console.WriteLine("0...quit");

        }
        public static void PrtinMenueZero()
        {
            Console.WriteLine("Do you want to start a demo mode?");
            Console.WriteLine("y/n:");
        }
    }
}


