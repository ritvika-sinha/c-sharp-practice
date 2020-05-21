using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{    
    class Program
    {
        public enum Mood
        {
            Crabby,       // 0
            Happy,        // 1
            Petulant,     // 2
            Elated        // 3
        };
        public enum Mood2
        {
            Crabby = -5,
            Happy = 5,
            Petulant = -2,
            Elated = 10
        };

        public enum Weekday
        {
            Sunday = 1,
            Monday,     // 2
            Tuesday,    // 3, etc.
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };

        static void Main(string[] args)
        {
            //Using Non-Default Constant Values for Enumeration Members
            

            Console.ReadKey();
        }
    }
}
