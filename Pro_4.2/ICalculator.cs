using System;
using System.Collections.Generic;
using System.Text;

namespace Pro4_2
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        int Div(int a, int b);
    }
}
