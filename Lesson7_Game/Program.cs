using System;

namespace Lesson7_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Person Hero = new Person(name);
            Person Enemy = new Person("Enemy 1");

        }
    }
}
