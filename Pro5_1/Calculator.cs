using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    /// <summary>
    /// 可进行两个数的四则运算
    /// </summary>
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
