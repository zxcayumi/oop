using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    /// <summary>
    /// 实现接口泛型方式一
    /// 继承接口时,同时把接口中用到的泛型类型明确下来了
    /// </summary>
    public class CCaculator : ICaculator<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
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
