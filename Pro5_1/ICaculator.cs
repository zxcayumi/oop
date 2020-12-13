using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    public interface ICaculator<T>
        where T : struct
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mul(T a, T b);
        T Div(T a, T b);
    }
}
