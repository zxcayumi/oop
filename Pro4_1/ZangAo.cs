using System;
using System.Collections.Generic;
using System.Text;

namespace Pro4_1
{
    public class ZangAo : Dog
    {
        public override int Size => 100;

        public override string Character
        {
            get
            {
                return "暴躁";
            }
        }

        public override void Bark()
        {
            Console.WriteLine("藏獒很大声的叫！");
        }

        public override void Run()
        {
            Console.WriteLine("藏獒跑得快！");
        }

        public override string ToString()
        {
            return $"我是一只藏獒，{Legs}条腿，{Eyes}只眼睛，体型{Size}号，性格{Character}";
        }
    }
}
