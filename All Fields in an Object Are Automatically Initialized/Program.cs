using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{ 
    class Person
    {
        public int age;
        public string name;
        public bool isMarried;
        public char gender;
    }
    class Program
    {        
        static void Main(string[] args)
        {
            //All Fields in an Object Are Automatically Initialized

            #region 1
            int x;
            //Console.WriteLine(x); this line will give error
            //[Use of unassigned local variable 'x']
            #endregion
            #region 2
            Person p = new Person();
            Console.WriteLine(p.age + " " + p.name + " " + p.isMarried + " " + p.gender);
            //the above line will not give error. 
            #endregion
            Console.ReadKey();
        }
    }
}
