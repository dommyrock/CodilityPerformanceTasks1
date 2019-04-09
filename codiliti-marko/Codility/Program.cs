using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Kruno2 algorithm = new Kruno2();
            //var result = algorithm.solution(new string[] { "test1a", "test2", "test1b", "test1c", "test3" },
            //    new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded" });
            //Console.WriteLine(result);

            algorithm.run();

            //int[][] test = new int[][]
            //{
            //    new int[]{ 3, 4, 5, 2, 5, 2 },
            //    new int[]{ 3, 4, 5, 5, 2 },
            //    new int[]{ 3, 4, 5, 2, 5, 5, 2 },
            //    new int[]{ 4, 5, 7, 1, 4, 4 }
            //};

            //for (int i = 0; i < test.Length; i++)
            //{
            //    int result1 = algorithm.solution(1000, test[i]);
            //    int result2 = algorithm.solution2(1000, test[i]);

            //    Console.WriteLine("i=" + i + ", result1=" + result1 + ", result2=" + result2);
            //}

            Console.ReadLine();
        }
    }
}