using System;
using System.Collections.Generic;
using System.Text;

namespace Pro3_1
{
    public class Student : Person
    {
        //#region 和Person重复的代码
        //public String IDNo;
        //public String Name;
        //public Char Sex;
        //public int Age;
        //#endregion

        public String School;
        public String Major;

        public void Listen()
        {
            Console.WriteLine(test);//孩子可以获得传家宝
            Console.WriteLine($"我是{School}的{Major}专业的学生，我在听课。");
            Console.WriteLine($"我叫{Name}名字，今年{Age}了！");

        }
    }
}
