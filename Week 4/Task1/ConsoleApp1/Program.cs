using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class ComplNum // class of complex numbers
    {
        public int a; //1st int
        public int b;// 2nd int
        public ComplNum()//parameterless constructor
        {

        }
        public void PrintInfo()//method printing to the console
        {
            Console.WriteLine( a + " + " + b  + "*i" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();//calling method F1 or F2
        }
        private static void F1() // method of serializing
        {
            ComplNum num = new ComplNum(); // new exapmle of class
            num.a = 12;
            num.b = 10;
            num.PrintInfo();
            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write); // new filestream to creat file
            XmlSerializer xs = new XmlSerializer(typeof(ComplNum)); //new serializer
            xs.Serialize(fs, num);//serializing our example of class
            fs.Close();//close filestream
        }
        private static void F2()//method of deserializing
        {
            FileStream fs = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);// new filestream to open and read file
            XmlSerializer xs = new XmlSerializer(typeof(ComplNum));//new serializer
            ComplNum CN = xs.Deserialize(fs) as ComplNum; // new example of class will be taken from deserializing of existing file
            fs.Close();//close filestream
            CN.PrintInfo();// calling method of printing
        }
    }
}
