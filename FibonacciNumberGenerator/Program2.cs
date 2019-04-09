using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumberGenerator
{
    internal class Program2
    {
        private static void Main(string[] args)
        {
            int lastNum = 0;
            int secoundToLast = 0;
            List<int> fibonacciNumbers = new List<int>(); //ads up past 2 numbers
            while (fibonacciNumbers.Count < 20)
            {
                if (fibonacciNumbers.Count == 0)
                {
                    fibonacciNumbers.Add(1);
                    fibonacciNumbers.Add(1);
                }
                else
                {
                    lastNum = fibonacciNumbers.Last();
                    secoundToLast = fibonacciNumbers[fibonacciNumbers.Count - 2];

                    fibonacciNumbers.Add(secoundToLast + lastNum);
                }
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            Console.ReadKey();
        }

        public static int Fibonacci(int n) //rekurzija ...calls itself
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Fibb(2) => 2  =  Fibb(1) =>1 ---> Fibb(0) =>1
            }
        }

        /*  exqmple
                     Fibb(3) => 3
               -->Fibb(2)  --->  Fibb(1)
            Fib(1) -->Fibb(0)   -->1
            */
    }
}