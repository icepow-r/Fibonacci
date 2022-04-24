using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckArgs(args);
            PrintSequence(int.Parse(args[0]));
        }

        static void CheckArgs(string[] args)
        {
            if (args.Length != 1 || !int.TryParse(args[0], out _))
            {
                ShowHelp();
                Environment.Exit(0);
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("usage: Fibonacci.exe <COUNT>");
            Console.WriteLine("COUNT is the number of elements to display on the screen");
            Console.WriteLine("COUNT must be integer");
        }

        static void PrintSequence(int count)
        {
            int first = 0, second = 1, temp;
            for (int i = 0; i < count; i++)
            {
                Console.Write(first + " ");
                temp = first;
                first = second;
                second += temp;
            }
        }
    }
}
