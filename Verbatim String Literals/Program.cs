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
            //Verbatim String Literals

            //using escape sequence
            string file1 = "C:\\MyDir\\Another Dir\\thefile.txt";
            //using @
            string file2 = @"C:\MyDir\Another Dir\thefile.txt";
            //not using \n for new line
            string address = @"First line
            Second line
            Third line";

            //including quotation mark in string using escape sequence
            Console.WriteLine("She said \"My name is Ritvika\"");
            //including quotation mark in string using verbatim string literal
            Console.WriteLine(@"She said ""My name is Ritvika""");

            Console.ReadKey();
        }
    }
}
