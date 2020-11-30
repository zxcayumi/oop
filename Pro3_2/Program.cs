using System;

namespace Pro3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chinese c = new Chinese();
            //c.SayHello();
            //c.Paint();

            //赋值运算符的 左边 与 右边，数据类型要一致
            //副职运算符的 左边 与 右边，左边数据类型包容右边数据类型
            Person p = new Chinese();
            p.SayHello();
            //p.Paint();//本质上是Chinese，但是这里仅仅把对象p看作普通的Person
        }
    }
}
