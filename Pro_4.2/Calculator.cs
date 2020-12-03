using System;
using System.Collections.Generic;
using System.Text;

namespace Pro4_2
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
