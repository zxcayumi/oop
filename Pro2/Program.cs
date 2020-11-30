using System;

namespace Pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //但凡是我们定义好的class设计，就是可以直接使用的一个数据类型
            /*构造函数：（类似我国的扶贫政策）
             * 1.如果一个类中，我们未显式的定义构造方法，编译器会自动的给他一个默认的构造方法（无参数）
             * 2.但凡我们自己定义了一个构造方法，编译器就不会给我们默认无参构造方法了。
            */
            Person p1 = new Person("张三",new DateTime(1999,10,19),'男');//创建好一个对象的时候，需要有一个初始化相关信息地方 ---> 构造方法
            p1.Money = 200;
            p1.Display();

            Person p2 = new Person("李四", new DateTime(2000, 1, 23), '女');
            p2.Money = 300;
            p2.Display();
            p2.Money = 250;//李四吃了顿饭，花了50元钱，还剩250元

            Console.WriteLine("张三还有{0}钱，李四还有{1}钱", p1.Money, p2.Money);

            ////外类使用静态变量的使用方式：类名.****
            //Person.Trees--;
            //Console.WriteLine(Person.Trees);

            p1.GetTreesCount();
            p2.GetTreesCount();
            p1.Cut();

            p2.GetTreesCount();


            Console.WriteLine();
        }
    }
}
