using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("How are you?");
            Console.WriteLine("How old are you?");
            Sum(5,5);
            Sub(7,1);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y) 
        {
            return x - y;
        }
    }
}
