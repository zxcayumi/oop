using System;

namespace Pro2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 2;

            ClassLib.Calculator c = new ClassLib.Calculator();
            Console.WriteLine(c.Mul(a, b));
            Console.WriteLine(c.Sum(1, 2, 3));

            Console.ReadLine();
        }
    }
}
