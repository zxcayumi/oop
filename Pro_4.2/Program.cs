using System;

namespace Pro4_2
{
    class Program
    {
        //计算器设计任务

        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            ICalculator c1 = new Calculator();
            ICalculator c2 = new JiSuanQi();

            Console.WriteLine(c1.Add(a,b));
            Console.WriteLine(c2.Mul(a,b));
        }
    }
}
