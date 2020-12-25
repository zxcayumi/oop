using System;
using System.Collections.Generic;

namespace Pro5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> s1 = new HashSet<int>();
            s1.Add(1);
            s1.Add(2);
            s1.Add(1);

            //Console.WriteLine("s1中元素个数："+s1.Count);
            //foreach (int item in s1)
            //{
            //    Console.Write(item + "\t");
            //}

            HashSet<int> s2 = new HashSet<int>();
            s2.Add(2);
            s2.Add(5);
            s2.Add(9);

            //获取两个集合中相同的元素：集合的交集
            //s1.IntersectWith(s2);//求s1和s2共同的元素，更新到s1中
            //Console.WriteLine("两个集合的交集内容是：");
            //foreach (int item in s1)
            //{
            //    Console.WriteLine(item);
            //}

            //求两个集合并集（相当于把两个集合合并）
            s1.UnionWith(s2);//s1与s2合并，并把合并结果更新到s1中
            Console.WriteLine("两个集合求交集：");
            foreach (int item in s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
