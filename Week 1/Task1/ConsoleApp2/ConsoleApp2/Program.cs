using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // read integer n 

            int[] a = new int[n]; // creating array a
            int[] b = new int[n]; // creating array b   

            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' }); //read numbers from input to array of string

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]); // converting from string to  array of integers
            }

            int c = 0; // new counter
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0) // way of identifying is it prime or no, besides "2"
                    {
                        c++; // using counter to count number of primes 
                    }
                }
                if (c == 2) // including "2" to condition
                {
                    b[i] = a[i];
                }
                else
                    b[i] = 0;
                c = 0;
            }

            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0)
                    c++;
            }

            Console.WriteLine(c); // output size of array of primes

            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0)
                    Console.Write($"{b[i]} "); // output array of primes
            }

            Console.ReadKey();
        }
    }
}
