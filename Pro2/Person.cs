using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Pro2
{
    class Person
    {
        //访问修饰符默认为private
        public static int Trees = 100;

        //特征（成员变量）
        private String name;//姓名
        private DateTime birthday;//出生日期
        private Char gender;//性别
        private decimal money = 100;

        //初始化成员变量内容-->构造方法
        //1.是一个方法（函数）
        //2.是一个特殊的方法（函数）:1)无返回类型  2)方法名与类名必须同名
        public Person(String name,DateTime birthday,Char gender)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
        }

        ~Person()
        {
            Console.WriteLine("我要被释放了");
        }

        //自动属性（C#6.0里面带来的新功能）--->成员变量与属性整合简化得来的(类似于成员变量定义的升级版)
        public int Height { get; } = 3;


        //通过属性保护起成员变量:控制外界读、控制外界写
        public String Name//属性名（变量的定义+方法的定义）
        {
            get //get方法：控制外界读操作
            {
                return name;
            }
        }

        public DateTime Birthday
        {
            get => birthday;
        }

        public char Gender 
        {
            get => gender;
        }
        public decimal Money { get => money; set => money = value; }

        //行为（成员方法）
        public void Display()
        {
            Console.WriteLine("我叫{0}，性别{1}，今年{2}岁了", name, gender, DateTime.Now.Year - birthday.Year);
        }

        public void Cut()
        {
            Trees--;
        }

        public void GetTreesCount()
        {
            Console.WriteLine(Trees);
        }
    }
}
