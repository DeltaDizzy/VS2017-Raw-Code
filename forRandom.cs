using System;

namespace RandomNumbers
{
    class NumberGen
    {
        static Random delta = new Random();
        public static void forLoopMethod()
        {
            Console.Write("your random numbers are: ");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            { 
                int dizzy = delta.Next(0, 9);
                Console.WriteLine();
                Console.WriteLine(dizzy);
            }
        }
     }
     class Program
     {
         static void Main(string[] args)
            {
                Console.Write("Using the For Loop Method ");
                forLoopMethod();
                Console.ReadKey();
                Console.WriteLine();
            }
      }
   }
}
