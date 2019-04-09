using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountNonDivisible
    {
        //55%, O(N ** 2)
        public int[] solution(int[] A)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] % A[j] != 0) count++;
                }

                result[i] = count;
            }

            return result;
        }

        //77%, isto kao prvo samo sa cachiranjem
        public int[] solution2(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(A[i]))
                {
                    result[i] = dict[A[i]];
                }
                else
                {
                    int count = 0;
                    for (int j = 0; j < A.Length; j++)
                    {
                        if (A[i] % A[j] != 0) count++;
                    }

                    result[i] = count;
                    dict[A[i]] = result[i];
                }
            }

            return result;
        }

        //77%
        public int[] solution3(int[] A)
        {
            int[] result = new int[A.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dict.ContainsKey(A[i])) dict[A[i]] = 1;
                else dict[A[i]]++;
            }

            foreach (int i in dict.Keys)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] % i == 0) result[j] += dict[i];
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = A.Length - result[i];
            }

            return result;
        }

        //100%, O(N * log(N)), moje rješenje prema ideji s neta
        public int[] solution4(int[] A)
        {
            int[] result = new int[A.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dict.ContainsKey(A[i])) dict[A[i]] = 1;
                else dict[A[i]]++;
            }

            Dictionary<int, int> divisors = new Dictionary<int, int>();

            foreach (int i in dict.Keys)
            {
                for (int j = i; j <= 2 * A.Length; j += i)
                {
                    if (!divisors.ContainsKey(j)) divisors.Add(j, 0);
                    divisors[j] += dict[i];
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = A.Length - divisors[A[i]];
            }

            return result;
        }

        //rješenje s neta
        public int[] solution5(int[] A) // time complexity O(N*log(N)), space complexity O(N)
        {
            int nIntCount = A.Length; // = N in problem statement
            int nMaxInt = nIntCount + nIntCount; // max possible input int; problem statement specifies this
            int[] anIntCounts = new int[nMaxInt + 1]; // array of counters for all possible input ints
                                                      // (plus a never-used counter for 0)
            int[] anDivisorCounts = new int[nMaxInt + 1]; // array of counters for counts of divisors
            int[] anNotDivCounts = new int[nIntCount]; // to be returned, length and order same as input array A
            foreach (int a in A) // transform input array A into counts of its ints
                anIntCounts[a]++;
            for (int i = 0; i <= nMaxInt; i++) // cycling thru counter array instead of input array A speeds things up!
                if (anIntCounts[i] > 0) // skip this iteration if input array A didn't have this int
                    for (int im = i; im <= nMaxInt; im += i) // mark multiples (they're divisable by this int, of course)
                                                             // since we're in the Sieve of Eratosthenes lesson
                        anDivisorCounts[im] += anIntCounts[i]; // mark by storing input int counts
                                                               // (some counts will never be read)
            for (int i = 0; i < nIntCount; i++)
                anNotDivCounts[i] = nIntCount - anDivisorCounts[A[i]]; // compute counts of non-divisors
                                                                       // (in original order of input array A)
            return anNotDivCounts;
        }
    }
}