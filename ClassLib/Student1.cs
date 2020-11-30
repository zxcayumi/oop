using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
    public class Student1
    {
        public Student1(int english, int math)
        {
            this.English = english;
            this.Math = math;
        }

        public int English { get; }

        public int Math { get; }

        public int Sum { get => English + Math; }
    }
}
