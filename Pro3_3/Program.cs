using System;

namespace Pro3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //将s视为Student，所以Student里面定义的SayHello生效
            Student s = new Student();
            s.SayHello();

            //将p视为Person，所以Person里面定义的SayHello生效
            Person p = new Student();
            p.SayHello();

            //is运算符（数据类型检测）
            Console.WriteLine(s is Student);
            Console.WriteLine(s is Person);
            Console.WriteLine(s is Cat);

            //as运算符（数据类型的转换）
            Person p1 = s as Person; //Person p1 = (Person)s;
            p1.SayHello();

            Object obj = "abc";
            Person p2 = (Person)obj; //obj as Person;
            Console.WriteLine(p2==null);
        }
    }
}
