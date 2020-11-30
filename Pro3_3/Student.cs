using System;
using System.Collections.Generic;
using System.Text;

namespace Pro3_3
{
    public class Student : Person
    {
        //new关键词仅仅是将父类中的方法暂时隐藏掉了
        //若把Student对象仅仅视作普通Person的话，父类Person中的SayHello方法会表现出来
        public new void SayHello()
        {
            Console.WriteLine("Student's SayHello");
        }
    }
}
