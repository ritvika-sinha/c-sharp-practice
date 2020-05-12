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
            //for loop
            for (int i = 0, j = 9; i < 10; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }

            Console.ReadKey();
        }
    }
}
