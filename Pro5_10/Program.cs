using System;
using System.Collections.Generic;

namespace Pro5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Key--Value    Key是唯一的，不允许重复的

            //统计一段英文各单词出现的次数
            String sentence = "Nevertheless, there is an increasing interest in generalizing convolutions to the graph domain. Advances in this direction are often categorized as spectral approaches and non-spectral approaches.";
            String[] words = sentence.Split(new char[] { ' ', ',', '.' });
            //foreach (String item in words)
            //{
            //    Console.WriteLine(item);
            //}//句子风格完成后，会有一些空格的字符串，后面使用时注意单独处理掉

            //Key:单词（不允许重复的）   Value：出现次数
            SortedDictionary<String, int> dic = new SortedDictionary<String, int>();
            foreach (String item in words)
            {
                if (item.Trim() != "")
                {
                    if (!dic.ContainsKey(item.ToLower()))//若当前单词item，字典中不存在
                    {
                        dic.Add(item.ToLower(), 1);//把单词加入到字典中，并初始化次数为1
                    }
                    else//字典中存在当前遍历到的单词item
                    {
                        dic[item.ToLower()] = dic[item.ToLower()] + 1; //单词item以前出现次数基础上，+1
                    }
                }
            }

            //输出字典所有内容
            foreach (var d in dic)
            {
                Console.WriteLine($"单词：{d.Key}\t次数：{d.Value}");
            }
        }
    }
}
