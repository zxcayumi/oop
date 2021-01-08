using System;

namespace Extend1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "abc";
            //name = Console.ReadLine();

            //传统写法：null 或着 长度为0
            //if (name == null || name.Length == 0)
            //{
            //    Console.WriteLine("姓名为null或者长度为0");
            //}

            //新语法写法
            if (name is null or { Length: 0 })
            {
                Console.WriteLine("name为null或者长度为0！");
            }

            //if (name != null) { }

            if (name is not null)
            {
                Console.WriteLine("name不为null");
            }

            //传统写法
            //if (name != null && name.Length > 0)
            //{
            //    Console.WriteLine("name不为null 并且 长度大于0！");
            //}

            //新语法写法
            if (name is not null and { Length: > 0 })
            {
                Console.WriteLine("name不为null 并且 长度大于0！");
            }
        }
    }
}
