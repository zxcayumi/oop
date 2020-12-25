using System;
using System.Collections;

namespace Pro5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int sum = 0;
            foreach (object obj in list)
            {
                sum += (int)obj;
            }
            Console.WriteLine(sum);
        }
    }
}
