using System;

namespace Extend1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch的增强模式匹配
            int age = 0;
            Console.Write("请输入年龄：");
            age = int.Parse(Console.ReadLine());

            //传统的：switch只能进行等值比较
            //新语法：switch可以进行范围的比较
            /*switch在进行范围比较时，只是一种语法糖（底层本质是转换成了if...else if...else方式）
              所以这种比较方式，效率和if方式是一样。
             */
            switch (age)
            {
                case >= 0 and < 3:
                    Console.WriteLine("bady");
                    break;
                case >= 3 and < 14:
                    Console.WriteLine("child");
                    break;
                case >= 14 and < 22:
                    Console.WriteLine("youth");
                    break;
                case >= 22 and < 60:
                    Console.WriteLine("adult");
                    break;
                case >= 60:
                    Console.WriteLine("old");
                    break;
            }
        }
    }
}
