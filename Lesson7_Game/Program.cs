﻿using System;

namespace Lesson7_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Witcher";
            Person Hero = new Person(name, 1);
            Person Enemy1 = new Person("Enemy 1", 2);

            int[,] map = new int[10, 14];
            map[1, 1] = 1;
            map[3, 3] = 2;

            while (Hero.Alive)
            {
                Hero.ShowInfo();
                ShowMap(map);
                Hero.Move(map, Console.ReadKey().KeyChar.ToString());
                Console.Clear();
            }
            Console.WriteLine("Game over");
        }
        static void ShowMap(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    ToConsoleWrite("|", ConsoleColor.Green);
                    if (map[i, k] == 1)
                        ToConsoleWrite("P", ConsoleColor.Cyan);
                    else if (map[i, k] == 2)
                        ToConsoleWrite("E", ConsoleColor.Red);
                    else
                        ToConsoleWrite(" ");
                }
                ToConsoleWriteLine("|", ConsoleColor.Green);
            }
            //for (int g = 0; g < map.GetLength(1); g++) Console.Write("__");
            //Console.WriteLine("_");
        }
        static void ToConsoleWrite(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        static void ToConsoleWriteLine(string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
