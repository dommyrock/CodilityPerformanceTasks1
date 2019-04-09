using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountSemiprimes
    {
        //55%, O(N * log(log(N)) + M * N) or O(M * N**3) or O(M * N ** (3/2))
        public int[] solution(int N, int[] P, int[] Q)
        {
            HashSet<int> primeNumbers = new HashSet<int>();
            for (int i = 2; i <= N; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primeNumbers.Add(i);
            }

            HashSet<long> semiPrimeNumbers = new HashSet<long>();
            foreach (int a in primeNumbers)
            {
                foreach (int b in primeNumbers)
                {
                    semiPrimeNumbers.Add((long)a * b);
                }
            }

            int[] result = new int[P.Length];
            if (semiPrimeNumbers.Count == 0) return result;

            long max = semiPrimeNumbers.Max();
            int[] semiPrimeCount = new int[max];

            for (int i = 0; i < semiPrimeCount.Length; i++)
            {
                if (i == 0) semiPrimeCount[i] = 0;
                else
                {
                    int increment = semiPrimeNumbers.Contains(i) ? 1 : 0;
                    semiPrimeCount[i] = semiPrimeCount[i - 1] + increment;
                }
            }

            for (int i = 0; i < P.Length; i++)
            {
                result[i] = semiPrimeCount[Q[i]] - semiPrimeCount[P[i] - 1];
            }

            return result;
        }

        //100%, O(N * log(log(N)) + M)
        public int[] solution2(int N, int[] P, int[] Q)
        {
            HashSet<int> primeNumbers = new HashSet<int>();
            for (int i = 2; i <= N; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primeNumbers.Add(i);
            }

            HashSet<long> semiPrimeNumbers = new HashSet<long>();
            foreach (int a in primeNumbers)
            {
                foreach (int b in primeNumbers)
                {
                    long semiPrime = (long)a * b;
                    if (semiPrime > N) break;
                    semiPrimeNumbers.Add(semiPrime);
                }
            }

            int[] result = new int[P.Length];
            if (semiPrimeNumbers.Count == 0) return result;

            int[] semiPrimeCount = new int[50000 + 1];

            for (int i = 0; i < semiPrimeCount.Length; i++)
            {
                if (i == 0) semiPrimeCount[i] = 0;
                else
                {
                    int increment = semiPrimeNumbers.Contains(i) ? 1 : 0;
                    semiPrimeCount[i] = semiPrimeCount[i - 1] + increment;
                }
            }

            for (int i = 0; i < P.Length; i++)
            {
                result[i] = semiPrimeCount[Q[i]] - semiPrimeCount[P[i] - 1];
            }

            return result;
        }
    }
}