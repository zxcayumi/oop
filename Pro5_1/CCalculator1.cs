using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    /// <summary>
    /// 实现泛型接口方式二
    /// 接口中的泛型传递到子类中,而没有直接具体化
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CCalculator1<T> : ICaculator<T>
        where T:struct
    {
        public T Add(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa + bb;
        }

        public T Sub(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa - bb;
        }

        public T Mul(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa * bb;
        }

        public T Div(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            return aa / bb;
        }
    }
}
