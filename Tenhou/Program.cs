﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Tenhou.Models;
using System.Diagnostics;
using System.IO;

namespace Tenhou
{
    class Program
    {
        static TenhouClient client;
        static Monitor monitor;
        static Controller controller;
        static AutoResetEvent gameEnd = new AutoResetEvent(false);
        static bool running = true;

        static void Init(string programPath)
        {
            client = new TenhouClient("aixile");
            
            gameEnd.Reset();

            client.OnLogin += () =>
            {
                //client.EnterLobby(0);
                client.Join(GameType.North);
                client.Join(GameType.North_fast);
                client.Join(GameType.East);
                client.Join(GameType.East_fast);
            };
            client.OnGameEnd += () => { gameEnd.Set(); };
            client.OnClose += () => { gameEnd.Set(); };

            monitor = new Monitor(client);
            monitor.Start();

            controller = new Controller(client, programPath);
            controller.Start();

            client.Login();
        }

        static void CheckKeyPress()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            //Trace.Listeners.Add(new ConsoleTraceListener());
            StreamWriter writer = File.CreateText("log.txt");
            writer.AutoFlush = true;
            Trace.Listeners.Add(new TextWriterTraceListener(writer));

            
            while (running)
            {
                Init(args[0]);
                gameEnd.WaitOne();
                client.Close();
                CheckKeyPress();
            }
        }
    }
}
