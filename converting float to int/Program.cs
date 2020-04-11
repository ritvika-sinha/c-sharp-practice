using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Person
    {
        public string name;
        public static int count = 0;
        public Person(string name)
        {
            this.name = name;
            count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //converting float to int
            float f = 4.8f;
            //truncating value
            int n1 = (int)f;
            Console.WriteLine("truncating {0} to int = {1}", f, n1);

            //rounding off to nearest int
            n1 = Convert.ToInt32(f);
            Console.WriteLine("rounding off {0} to int = {1}", f, n1);

            f = 4.2f;
            n1 = Convert.ToInt32(f);
            Console.WriteLine("rounding off {0} to int = {1}", f, n1);

            //if the float num is halfway between two int, it is rounded to the nearest EVEN num
            f = 4.5f;
            n1 = Convert.ToInt32(f);
            Console.WriteLine("rounding off {0} to int = {1}", f, n1);

            f = 5.5f;
            n1 = Convert.ToInt32(f);
            Console.WriteLine("rounding off {0} to int = {1}", f, n1);

            Console.ReadKey();
        }
    }
}
