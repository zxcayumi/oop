using System;
using System.Collections.Generic;
using System.Text;

namespace Pro1
{
    class Dog
    {
        //1.特征
        public String Name;
        public Color Color;
        public String Size;

        //2.行为
        public void Introduce()
        {
            Console.WriteLine($"我是{Name}，毛色是{Color}，体型是{Size}");
        }

        public void Bark()
        {
            Console.WriteLine("狗叫");
        }

        public void Eat()
        {
            Console.WriteLine("啃骨头");
        }
    }
}
