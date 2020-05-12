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
            //Average of an Array of Numbers
            int[] scores = { 2, 4, 1, 7, 5, 9 };
            double avg = scores.Average();
            Console.WriteLine(avg);

            Console.ReadKey();
        }
    }
}
