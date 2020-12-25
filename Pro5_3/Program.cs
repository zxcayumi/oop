using System;
using System.Collections;

namespace Pro5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("abc");
            list.Add('D');
            list.Add(true);
            list.Add(null);
            list.Add(3.14f);

            int[] nums = { 4,5,6,7};
            list.AddRange(nums);

            //ArrayList的遍历
            //foreach (object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //以索引形式，直接访问具体的某一个元素
            Console.WriteLine(list[3]);

            //删除某一个元素
            //Console.WriteLine("删除前元素个数："+list.Count);
            //list.Remove(true);
            //Console.WriteLine("删除后元素个数："+list.Count);

            //按索引删除某元素
            //list.RemoveAt(5);
            //Console.WriteLine("删除第5号元素后，list中的元素有：");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //批量删除多个元素
            list.RemoveRange(2, 3);//从第2号索引开始，删除3个元素
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
