using System;

namespace RandomNumbers
{
    class NumberGen
    {
        static Random delta = new Random();
        public static void whileLoopMethod()
        {
            int i = 0;
            Console.Write("your random numbers are:");
            Console.WriteLine();
            while (i < 5)
             {
                int a = delta.Next(0, 9);
                Console.WriteLine();
                Console.WriteLine(a);
                i++;
             }
        }
        public static void forLoopMethod()
        {
            Console.Write("you random numbers are: ");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            { 
                int dizzy = delta.Next(0, 9);
                Console.WriteLine();
                Console.WriteLine(dizzy);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Using the While Loop Method ");
                whileLoopMethod();
                Console.ReadKey();
                Console.WriteLine();
                Console.Write("Using the For Loop Method ");
                forLoopMethod();
                Console.ReadKey();
                Console.WriteLine();
            }

        }
    }
}