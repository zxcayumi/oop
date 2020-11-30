using System;

namespace Pro4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new ZangAo();//因为子类都是通过override方式重写的父类的方法。
            Console.WriteLine(d.ToString());
            d.Run();
            d.Bark();
            d.Guard();
        }
    }
}
