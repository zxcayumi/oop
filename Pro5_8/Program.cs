using System;
using System.Collections.Generic;

namespace Pro5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //字典元素的访问及遍历
            //(Key,Value)
            //定义字典，存储学生信息（学号，姓名）
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("001", "张三");
            dic.Add("002", "李四");
            dic.Add("004", "张飞");
            dic.Add("003", "王五");
            dic.Add("006", "刘备");
            dic.Add("005", "关羽");

            //通过key，检索对应的value
            Console.WriteLine($"学号为003的学生姓名是：{dic["003"]}");

            foreach (KeyValuePair<String,String> item in dic)
            {
                Console.WriteLine("学号：" + item.Key + "\t姓名：" + item.Value);
            }

            //检测字典中是否存在某个Key的信息
            if (dic.ContainsKey("001"))
            {
                Console.WriteLine("存在011学号的学生信息");
            }
            else
            {
                Console.WriteLine("不存在011学号的学生信息");
            }
        }
    }
}
