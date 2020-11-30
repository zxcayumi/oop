using System;
using System.Collections.Generic;
using System.Text;

namespace Pro3_1
{
    public class Person
    {
        //特征
        public String IDNo;
        public String Name;
        public Char Sex;
        public int Age;
        protected String test;//传家宝

        //行为-->函数（有小括号，动作）
        public void Introduce()
        {
            Console.WriteLine($"我叫{Name},今年{Age}了，性别{Sex},身份证号{IDNo}");
        }

        public void Run()
        {
            Console.WriteLine("人在跑步");
        }
    }
}
