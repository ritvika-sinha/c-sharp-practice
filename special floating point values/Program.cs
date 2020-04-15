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
            //special floating point values

            //Not a number (Nan)
            float f = 0.0f / 0.0f;
            f = float.NaN; //alternative way            
            Console.WriteLine(float.IsNaN(f)); //True

            //positive infinity
            f = 1.0f / 0.0f; //method 1
            f = float.PositiveInfinity; // method 2
            Console.WriteLine(float.IsInfinity(f)); //true
            Console.WriteLine(float.IsPositiveInfinity(f)); //true

            //negative infinity
            f = -1.0f / 0.0f; //method 1
            f = float.NegativeInfinity; //method 2 
            Console.WriteLine(float.IsNegativeInfinity(f));

            //equality operator dosent work for NaN
            
            //using static method
            bool b = float.IsNaN(0.0f / 0.0f); //true

            //using equality operator
            b = (0.0f / 0.0f) == float.NaN; //false

            //object.Equals does work
            b = object.Equals(0.0f / 0.0f, float.NaN);//true
            
            Console.ReadKey();
        }
    }
}
