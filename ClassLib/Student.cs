using System;

namespace ClassLib
{
    public class Student
    {
        private int english;
        private int math;

        public Student(int english, int math)
        {
            this.english = english;
            this.math = math;
        }

        public int English { get => english; set => english = value; }
        public int Math { get => math; set => math = value; }
        public int Sum { get => english + math; }

        //通过运算符重载实现Student类的+运算
        public static int operator + (Student s0, Student s1)
        {
            return s0.Sum + s1.Sum;
        }

        public static Boolean operator >(Student s0, Student s1)
        {
            return s0.Sum > s1.Sum;
        }

        public static Boolean operator <(Student s0, Student s1)
        {
            return s0.Sum < s1.Sum;
        }
    }
}
