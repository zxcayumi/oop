using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    /// <summary>
    /// 可进行两个数的四则运算
    /// </summary>
    public class Calculator2
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Mul(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Div(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
