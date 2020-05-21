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
            Crabby = -5,
            Happy = 5,
            Petulant = -2,
            Elated = 10
        };

        static void Main(string[] args)
        {
            //An Enum Type’s ToString Method Displays the Member’s Name

            //example 1
            int x = 42;
            Console.WriteLine(x.ToString());   // Displays: 42
            Console.WriteLine(x);     // Same thing--ToString implicitly called

            //example 2
            Mood myMood = Mood.Crabby;
            Mood dogsMood = Mood.Elated;

            Console.WriteLine(myMood);     // ToString implicitly called; displays: Crabby

            Console.WriteLine(dogsMood);   // Displays: Elated

            Console.ReadKey();
        }
    }
}
