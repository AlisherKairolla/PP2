using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public string name;
        public override string ToString()
        {
            return name + "!!!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "AAA";
            Console.WriteLine(s);    
        }
    }
}
