using System;
using System.Collections.Generic;
using System.Text;

namespace Pro1
{
    class Person 
    {
        //不管“特征”、“行为”，都隶属于class中，称之为这个类的成员

        //1.特征（变量）--->成员变量（也叫做成员字段）
        public String Name;
        public int Legs;
        public int Hands;
        public int Height;
        public int Weight;

        //2.行为-->方法（在面向对象的角度中，我们称函数为“方法”）--->成员方法
        public void Eat()
        {
            Console.WriteLine("开始吃饭");
        }

        public void Sport()
        {
            Console.WriteLine("开始运动");
        }

        public void Sleep()
        {
            Console.WriteLine("开始睡觉");
        }

    }
}
