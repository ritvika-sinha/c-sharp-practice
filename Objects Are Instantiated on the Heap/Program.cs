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
        public Person(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Objects Are Instantiated on the Heap
            Person obj = new Person("Ritvika");
            Console.WriteLine(obj.name);
            Console.ReadKey();
        }
    }
}
