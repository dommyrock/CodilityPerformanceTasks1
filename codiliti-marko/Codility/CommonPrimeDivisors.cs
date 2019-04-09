using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CommonPrimeDivisors
    {
        //61%, O(Z * (max(A) + max(B)))
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                HashSet<int> primeDivisorsA = GetPrimeDivisors(A[i]);
                HashSet<int> primeDivisorsB = GetPrimeDivisors(B[i]);

                if (primeDivisorsA.SetEquals(primeDivisorsB)) count++;
            }

            return count;
        }

        private HashSet<int> GetPrimeDivisors(int n)
        {
            int[] array = new int[n + 1];
            int i = 2;
            while (i * i <= n)
            {
                if (array[i] == 0)
                {
                    int k = i * i;
                    while (k <= n)
                    {
                        if (array[k] == 0) array[k] = i;
                        k += i;
                    }
                }
                i++;
            }

            HashSet<int> primeFactors = new HashSet<int>();
            while (array[n] > 0)
            {
                primeFactors.Add(array[n]);
                n /= array[n];
            }
            primeFactors.Add(n);
            return primeFactors;
        }

        private int gcd(int a, int b)
        {
            if (a % b == 0) return b;
            else return gcd(b, a % b);
        }

        //100%, O(Z * log(max(A) + max(B))**2), moje rješenje uz pomoć rješenja s neta
        public int solution2(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int a = A[i];
                int b = B[i];

                int divisor = gcd(a, b);

                while (true)
                {
                    int div = gcd(a, divisor);
                    if (div == 1) break;

                    a /= div;
                }

                while (true)
                {
                    int div = gcd(b, divisor);
                    if (div == 1) break;

                    b /= div;
                }

                if (a == 1 && b == 1) count++;
            }

            return count;
        }
    }
}