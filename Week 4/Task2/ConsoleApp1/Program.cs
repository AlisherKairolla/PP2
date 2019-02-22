using System;
using System.IO;
using System.Xml.Serialization;
// 50-54 = D 55-59 = D+ 60-64 = C- 65-69 = C 70-75 = C+ 75-79 = B- 80-84=B 85-89 =B+ 90-94=A- 95-100=A
namespace ConsoleApp1
{
    public class Mark //создаем класс оценки
    {
        public int pnts; // mark in number 
        public string ltr; // mark in one letter
        public void getLetter()
        {
            if(  pnts >= 0 && pnts <= 49 ){
                ltr = "F";
            }
            if (pnts >= 50 && pnts <= 54)
            {
                ltr = "D";
            }
            if (pnts >= 55 && pnts <= 59)
            {
                ltr = "D+";
            }
            if (pnts >= 60 && pnts <= 64)
            {
                ltr = "C-";
            }
            if (pnts >= 65 && pnts <= 69)
            {
                ltr = "C";
            }
            if (pnts >= 70 && pnts <= 74)
            {
                ltr = "C+";
            }
            if (pnts >= 75 && pnts <= 79)
            {
                ltr = "B-";
            }
            if (pnts >= 80 && pnts <= 84)
            {
                ltr = "B";
            }
            if (pnts >= 85 && pnts <= 89)
            {
                ltr = "B+";
            }
            if (pnts >= 90 && pnts <= 94)
            {
                ltr = "A-";
            }
            if (pnts >= 95 && pnts <= 100)
            {
                ltr = "A";
            }
        }//method which define char to mark
        public Mark() //parametrless constructor
        {

        }
        public override string ToString() // method which helps to output the letter
        {
            return ltr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F1(); // call method F1
        }
        static void F1() // method F1
        {
            Mark mrk = new Mark(); //new example of class
            mrk.pnts = int.Parse(Console.ReadLine()); // reading points from console
            mrk.getLetter(); // call method getLetter
            Console.WriteLine(mrk.pnts + " " + mrk.ltr); // writing to the console
            FileStream fs = new FileStream("points.txt", FileMode.Create, FileAccess.Write);  // new filestream to create txt file   
            XmlSerializer xs = new XmlSerializer(typeof(Mark)); // new serializer
            xs.Serialize(fs, mrk);// serializing our class
            fs.Close(); // closing filestream

        }
    }
}
