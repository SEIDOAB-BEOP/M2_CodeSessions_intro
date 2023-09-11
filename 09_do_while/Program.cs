// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Make choice!");
                Console.WriteLine("1 - Say Hello");
                Console.WriteLine("2 - Say Goodbye");
                Console.WriteLine("3 - Say Good morning");
                Console.WriteLine("4 - Say Good evening");
                Console.WriteLine("Q - Quit");
                key = Console.ReadKey();

                /*
                if (key.KeyChar == '1')
                {
                    Console.WriteLine("\n\nHello Hello");
                }
                else if (key.KeyChar == '2')
                {
                          Console.WriteLine("\n\Bye Bye");
                }
                else if (key.KeyChar == '3')
                {
                    Console.WriteLine("\n\nBreakfast?");
                }
                else if (key.KeyChar == '4')
                {
                    Console.WriteLine("\n\nDinner?");
                }
                */

                switch (key.KeyChar)
                {
                    case '1':
                        Console.WriteLine("\n\nHello Hello");
                        break;
                    case '2':
                        Console.WriteLine("\n\nBye Bye");
                        break;
                    case '3':
                        Console.WriteLine("\n\nBreakfast?");
                        break;
                    case '4':
                        Console.WriteLine("\n\nDinner?");
                        break;
                }


            }
            while (key.KeyChar != 'Q');

            Console.WriteLine();
            Console.WriteLine("Done");
            
        }
    }
}