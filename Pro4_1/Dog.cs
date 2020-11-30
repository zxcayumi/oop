using System;
using System.Collections.Generic;
using System.Text;

namespace Pro4_1
{
    /// <summary>
    /// 抽象类，半成品
    /// </summary>
    public abstract class Dog
    {
        //1.特征
        public int Legs = 4;//腿
        public int Eyes = 2;//眼
        public int Tails = 1;//尾巴

        #region 未完成的特征
        public abstract int Size//体型
        {
            get;//get没有大括号和内容体，未完成的
        }

        public abstract String Character
        {
            get;//get没有大括号和内容体，未完成的
        }
        #endregion

        //2.行为
        public void Guard()
        {
            Console.WriteLine("Dog正在看门！");
        }

        #region 未完成的行为
        public abstract void Run();

        public abstract void Bark();
        #endregion
    }
}
