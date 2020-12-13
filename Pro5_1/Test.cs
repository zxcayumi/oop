using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    public class Test
    {
        //函数的泛型,在函数名后面紧跟上尖括号<T>
        public void Introduction<T>(T a)
        {
            Console.WriteLine(a.GetType());
        }

        //public void Show(T b) //上面函数定义的泛型仅在上面函数范围内有效，和Show这个函数没关系
        //{ }
    }
}
