using System;

namespace Pro5_2
{
    class Program
    {
        //定义delegate
        //仅仅是帮别人做事情-->没有具体的函数体内容-->是一个规则的声明
        //函数声明+delegate关键字
        //完成某一个数的平方的计算
        delegate T Square<T>(T a);

        static int CalSquare(int a)
        {
            return a * a;
        }

        delegate T3 DeTest<in T1,in T2,out T3>(T1 f, T2 d);

        static int Test(float f, double d)
        {
            return (int)(f + d);
        }

        static void Main(string[] args)
        {
            DeTest<float, double, int> d = Test;
            Console.WriteLine(d(3.14f,99.88));

            //定义一个具体的代理ds；
            //给代理ds分配了一个具体的任务，ds代替CalSquare这个函数去执行它的函数体内容。
            //Square<int> ds = CalSquare;
            //Console.WriteLine(ds(3));
        }
    }
}
