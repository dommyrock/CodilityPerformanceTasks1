using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Ladder
    {
        //37%, 75% correctness, ne radi za veće brojeve (čak ni kada stavim long umjesto int)
        public int[] solution(int[] A, int[] B)
        {
            int max = A.Max();
            List<int> fibbNumbers = FibbNumbers(max);

            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = fibbNumbers[A[i] + 1] % (int)Math.Pow(2, B[i]);
            }

            return result;
        }

        private List<int> FibbNumbers(int n)
        {
            List<int> list = new List<int>();
            int i = 0;
            while (i <= n + 2)
            {
                double a = Math.Pow(((1 + Math.Sqrt(5.0)) / 2), i);
                double b = Math.Pow(((1 - Math.Sqrt(5.0)) / 2), i);

                int number = (int)Math.Round((a - b) / Math.Sqrt(5));
                list.Add(number);
                i++;
            }

            return list;
        }

        //62%, O(L**2)
        public int[] solution2(int[] A, int[] B)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = FibbNumbersWithModulo(A[i] + 1, B[i]);
            }

            return result;
        }

        private int FibbNumbersWithModulo(int n, int b)
        {
            int modulo = (int)Math.Pow(2, b);

            int[] fibbNumbers = new int[n + 1];
            fibbNumbers[0] = 0;
            fibbNumbers[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibbNumbers[i] = (fibbNumbers[i - 1] + fibbNumbers[i - 2]) % modulo;
            }

            return fibbNumbers[n];
        }

        //100%, O(L)
        public int[] solution3(int[] A, int[] B)
        {
            int max = A.Max();
            List<int> exponents = B.Distinct().ToList();
            Dictionary<int, int[]> cache = CacheFibbNumbersWithModulo(max + 1, exponents);

            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = cache[B[i]][A[i] + 1];
            }

            return result;
        }

        private Dictionary<int, int[]> CacheFibbNumbersWithModulo(int n, List<int> exponents)
        {
            Dictionary<int, int[]> cache = new Dictionary<int, int[]>();

            foreach (int exponent in exponents)
            {
                int modulo = (int)Math.Pow(2, exponent);

                int[] fibbNumbers = new int[n + 1];
                fibbNumbers[0] = 0;
                fibbNumbers[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    fibbNumbers[i] = (fibbNumbers[i - 1] + fibbNumbers[i - 2]) % modulo;
                }

                cache.Add(exponent, fibbNumbers);
            }
            return cache;
        }
    }
}