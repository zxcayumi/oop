using System;
using System.Collections.Generic;//添加命名空间的引用

namespace Pro5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //List集合的定义
            List<int> list = new List<int>();

            //添加元素
            list.Add(2);
            list.Add(5);
            list.AddRange(new int[] { 2, 5, 8 });

            //遍历元素
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //访问某位置元素
            Console.Write("访问第3号位置的元素为：");
            Console.WriteLine(list[3]);

            //排序
            list.Sort();
            Console.WriteLine("排序完成后List遍历结果：");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //元素顺序反转
            list.Reverse();
            Console.WriteLine("元素反转后List遍历结果：");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //清空所有元素
            Console.WriteLine("Clear前List中元素个数：" + list.Count);
            list.Clear();
            Console.WriteLine("Clear后List中元素个数：" + list.Count);
        }
    }
}
