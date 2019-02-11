using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Method(n);

        }

        static void Method(int n)
        {
            string[] s = Console.ReadLine().Split(' ');

            int[] arr = new int[n * 2]; // creating array with 2x amount of elements

            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                arr[i + j] = int.Parse(s[i]);
                arr[i + j + 1] = int.Parse(s[i]);
                j++;
            }

            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}