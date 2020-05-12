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
            //String.IndexOf()
            //returns a 0 based
            string name = "ritvika sinha";

            //finding the 1st occurrence of 'i'
            int n = name.IndexOf('i');
            Console.WriteLine(n); //1

            //finding a 2nd occurrence of i
            n = name.IndexOf('i', n + 1);
            Console.WriteLine(n); //4

            //find the 1st occurrence of any vowel
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            n = name.IndexOfAny(vowels);
            Console.WriteLine(n); //1

            //searching a substring            
            Console.WriteLine(name.IndexOf("sin")); //8

            Console.ReadKey();
        }
    }
}
