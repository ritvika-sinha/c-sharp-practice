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
            //Comparing String Values
            int n = string.Compare("Sean", "Steinbeck");    // -1
            n = string.Compare("Sean", "Bozo");             // 1
            n = string.Compare("Sean", "Sean");             // 0
            n = string.Compare("Sean", "sean");             // 1 ("S" > "s")

            //ignoring case, set option parameter bool ignorecase as true
            n = string.Compare("Sean", "sean", true);       //0

            Console.ReadKey();
        }
    }
}
