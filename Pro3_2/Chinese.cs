using System;
using System.Collections.Generic;
using System.Text;

namespace Pro3_2
{
    public class Chinese : Person
    {
        /// <summary>
        /// 对父类行为的继承并发展
        /// </summary>
        public override void SayHello()//override重写覆盖
        {
            //base.SayHello();//base关键词代表这父类，通过它可以调用父类中的内容（字段、方法）
            Console.WriteLine("Chinese's SayHello");
        }

        public void Paint()
        {
            Console.WriteLine("Chinese's Paint");
        }
    }
}
