using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(2, 3));
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
