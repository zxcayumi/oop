using System;
using System.Collections.Generic;
using System.Text;

namespace Pro5_1
{
    //泛型直接应用在类定义上
    public class NewCalculator<A> 
        where A:struct //限制类型占位符使用的时候，只能是值类型替换
        //where B:class
    {
        public A Add(A a, A b)//T类型的占位符，有可能是任何数据类型
        {
            dynamic aa = a;//dynamic编译时不检查数据类型，运行时才动态获取数据的类型
            dynamic bb = b;

            return aa + bb;
        }

        public A Sub(A a, A b)
        {
            dynamic aa = a;
            dynamic bb = b;

            return aa - bb;
        }

        public A Mul(A a, A b)
        {
            dynamic aa = a;
            dynamic bb = b;

            return aa * bb;
        }

        public A Div(A a, A b)
        {
            dynamic aa = a;
            dynamic bb = b;

            return aa / bb;
        }
    }
}
