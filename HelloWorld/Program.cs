using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Convert.ToInt32("1234");
            int j = int.Parse("1234");
        }
    }
}
