using System;
using ClassLib;

namespace Pro2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用其他项目中的类时
            //1.写清楚详细的路径
            ClassLib.Student s = new ClassLib.Student(89, 91);
            //2.类文件最上方，添加namespace的引用，就可以快捷的使用这个namespace路径下面的所有类
            Student s1 = new Student(88, 99);

            //类的访问修饰符：public、internal（类访问修饰符没有private一说，对当前项目内的其它类可访问）
            //Student1未指定访问修饰时（internal），从Pro2_1项目中访问不到Student1
            //Student1 s3 = new Student1(78, 87);
            //Console.WriteLine($"英语成绩：{s3.English}，数学成绩：{s3.Math}，总成绩：{s3.Sum}");

            Student s2 = new Student(77, 92);

            Student[] stus = new Student[3];
            stus[0] = s;
            stus[1] = s1;
            stus[2] = s2;

            int sum = 0;
            foreach (Student item in stus)
            {
                sum += item.Sum;
            }
            Console.WriteLine(sum);

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            //加法运算符，不知道如何计算两个Student的操作（编译器不知道如何处理了--->我们告诉他怎么办）
            //Console.WriteLine(s + s1);

            Console.WriteLine($"s的总分为：{s.Sum}，s1的总分为{s1.Sum}");
            if (s > s1)
            {
                Console.WriteLine("s>s1");
            }
            else
            {
                Console.WriteLine("s<=s1");
            }

            Console.ReadKey();
        }
    }
}
