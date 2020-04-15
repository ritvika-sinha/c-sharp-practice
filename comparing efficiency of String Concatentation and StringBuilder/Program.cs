using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //comparing efficiency of String Concatentation and StringBuilder

            var watch = new System.Diagnostics.Stopwatch();

            //example 1
            string s1 = "";
            watch.Start();
            for (int i = 0; i < 50000; i++)
            {
                s1 = s1 + i.ToString();
            }
            watch.Stop();
            Console.WriteLine($"Execution Time for example 1: {watch.ElapsedMilliseconds} ms");

            //example 2
            StringBuilder sb = new StringBuilder("");
            watch.Start();
            for (int i = 0; i < 50000; i++)
            {
                sb.Append(i.ToString());
            }
            watch.Stop();
            Console.WriteLine($"Execution Time for example 2: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
