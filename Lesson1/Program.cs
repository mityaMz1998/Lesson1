using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(2, 3, 4));
            Console.WriteLine(Multi(2, 3));
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Multi(int x, int y)
        {
            return x * y;
        }
    }
}
