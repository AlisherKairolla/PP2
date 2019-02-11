using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Student
    {
        public string name; // introducing name
        public string id;   // introducing id
        public string year; // introducing year

        public void PrintInfo() // adding function, which will output 
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student  // function of inputing
            {
                name = Console.ReadLine(), // input name
                id = Console.ReadLine(),  // input id
                year = Console.ReadLine()  // input year
            };
            s.PrintInfo(); // calling function of outputing to "s"
        }
    }
}