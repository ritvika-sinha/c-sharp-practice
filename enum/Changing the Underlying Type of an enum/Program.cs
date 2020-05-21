using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{    
    class Program
    {
        public enum Mood { Crabby, Happy, Petulant, Elated };   // type is int

        public enum MoodByte : byte { Crabby, Happy, Petulant, Elated };

        static void Main(string[] args)
        {
            //Changing the Underlying Type of an enum

            // 4 bytes
            Console.WriteLine("Each element is {0} bytes", sizeof(Mood));

            // 1 byte
            Console.WriteLine("Each element is {0} bytes", sizeof(MoodByte));

            Console.ReadKey();
        }
    }
}
