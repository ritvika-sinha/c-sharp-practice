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
            //Static Members of a Class
            Person obj1 = new Person("Ritvika");
            Person obj2 = new Person("Rohit");
            Person obj3 = obj1;
            Console.WriteLine(obj1.name);
            Console.WriteLine("total number of objects created = {0}", Person.count);
            Console.ReadKey();
        }
    }
}
