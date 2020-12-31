using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Pro5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomSortRule rule = new CustomSortRule();//实例化一个排序规则
            SortedDictionary<String, String> dic = 
                new SortedDictionary<string, string>(rule);
            dic.Add("001", "张三");
            dic.Add("002", "李四");
            dic.Add("004", "张飞");
            dic.Add("003", "王五");
            dic.Add("006", "刘备");
            dic.Add("005", "关羽");
            dic.Add("ad", "吕布");
            dic.Add("12334", "孙权");

            foreach (var item in dic)
            {
                Console.WriteLine($"学号：{item.Key}\t姓名：{item.Value}");
            }
        }
    }

    //自定义字典集合Key的排序规则（C#有专门的父类，控制我们规则的规范）
    public class CustomSortRule : Comparer<String>
    {
        //父类里面提供的具体的比较规则函数，从这里面写上我们的具体的比较方式
        public override int Compare([AllowNull] string x, [AllowNull] string y)
        {
            //x>y : 返回1
            //x<y : 返回-1
            //x==y: 返回0
            //return x.CompareTo(y) * -1;

            return x.Length - y.Length;
        }
    }
}
