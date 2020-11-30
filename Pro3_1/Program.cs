using System;

namespace Pro3_1
{
    //Person父类
    //Student子类（子类继承了父类的public和protected信息）
    //Program类（外人）

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.IDNo = "001";
            s.Name = "张三";
            s.Sex = '男';
            s.Age = 18;
            s.School = "****大学";
            s.Major = "计算机科学与技术";

            s.Introduce();
            s.Listen();
        }
    }
}
