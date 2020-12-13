using System;

namespace Pro5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator c = new Calculator();//int类型计算器
            //Calculator1 c1 = new Calculator1();//float类型计算器
            //Calculator2 c2 = new Calculator2();//decimal类型计算器

            //Console.WriteLine(c.Mul(3,5));
            //Console.WriteLine(c1.Mul(3.14f, 1.2f));
            //Console.WriteLine(c2.Mul(3.1415926m,1.222m));

            //NewCalculator<int> c = new NewCalculator<int>();
            //Console.WriteLine(c.Add(3,5));

            //NewCalculator<float> c1 = new NewCalculator<float>();
            //Console.WriteLine(c1.Mul(3.21f,3.21f));

            //NewCalculator<double> c2 = new NewCalculator<double>();
            //Console.WriteLine(c2.Mul(5.232343243,3.12344));

            //Student s1 = new Student();
            //Student s2 = new Student();
            //NewCalculator<Student> c = new NewCalculator<Student>();
            //Console.WriteLine(c.Add(s1, s2));

            //Test t = new Test();
            //t.Introduction<int>(3);

            CCaculator cc1 = new CCaculator();
            Console.WriteLine(cc1.Add(5,8));

            CCalculator1<double> cc2 = new CCalculator1<double>();
            Console.WriteLine(cc2.Add(3.223432,8.3232));
        }
    }
}
