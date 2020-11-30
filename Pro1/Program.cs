using System;

namespace Pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();//通过new关键字，将Person类具体化，形成一个实实在在的人（对应变量p）
            //p.Name = "张三";
            //p.Legs = 2;
            //p.Hands = 2;
            //p.Height = 178;
            //p.Weight = 70;

            //p.Eat();
            //p.Sport();
            //p.Sleep();

            Dog d;//声明一个Dog类型的对象d，此时还未分配存储空间，默认值为null
            d = new Dog();//通过new关键字对对象d实例化，此时真正的分配了存储空间，对象创建完毕。
            d.Name = "金毛";
            d.Size = "大型犬";
            d.Color = Color.金色;//通过枚举类型限制用户的选择范围，禁止用户自我发挥乱写

            d.Eat();
            d.Introduce();
            d.Bark();

            Console.ReadKey();
        }
    }
}
