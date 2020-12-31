using System;
using System.Collections.Generic;

namespace Pro5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义字典变量
            Dictionary<int, String> dic = new Dictionary<int, string>();

            //通过Add方法添加字典元素
            dic.Add(1, "数字1");
            dic.Add(2, "数字2");
            dic.Add(3, "数字3");
            //dic.Add(3, "能有一个key对应多个value吗");

            //key得方式添加字典元素
            dic[8] = "test";
            dic[8] = "new test value";//如果字典中已存在key为8得元素，则把新value覆盖掉老的value

            //在调用构造函数后，立即初始化填充字典元素
            Dictionary<String, float> dic1 = new Dictionary<string, float>
            {
                ["pi"] = 3.1415926f,
                ["theta"] = 0.025f
            };
            dic1.Add("tt", 344.2f);
        }
    }
}
