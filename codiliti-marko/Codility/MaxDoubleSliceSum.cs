using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxDoubleSliceSum
    {
        //61%, O(N ** 2), iako je zapravo O(N3)
        public int solution(int[] A)
        {
            int[] sums = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0) sums[i] = A[i];
                else sums[i] = sums[i - 1] + A[i];
            }

            int max = int.MinValue;
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        int sum = sums[k - 1] - sums[i] - A[j];
                        if (sum > max) max = sum;
                    }
                }
            }

            return max;
        }

        //100%, O(N), kombinacija rješenja s interneta
        public int solution2(int[] A)
        {
            int[] maxEndingLeft = new int[A.Length];
            int[] maxEndingRight = new int[A.Length];

            int maxEnding = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                maxEnding = Math.Max(0, maxEnding + A[i]);
                maxEndingLeft[i] = maxEnding;
            }

            maxEnding = 0;
            for (int i = A.Length - 2; i > 0; i--)
            {
                maxEnding = Math.Max(0, maxEnding + A[i]);
                maxEndingRight[i] = maxEnding;
            }

            int max = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                int sum = maxEndingLeft[i - 1] + maxEndingRight[i + 1];
                if (sum > max) max = sum;
            }

            return max;
        }

        //100%, O(N), rješenje nije moje već s interneta
        public int solution3(int[] A)
        {
            int N = A.Length;
            int[] K1 = new int[N];
            int[] K2 = new int[N];

            for (int i = 1; i < N - 1; i++)
            {
                K1[i] = Math.Max(K1[i - 1] + A[i], 0);
            }
            for (int i = N - 2; i > 0; i--)
            {
                K2[i] = Math.Max(K2[i + 1] + A[i], 0);
            }

            int max = 0;

            for (int i = 1; i < N - 1; i++)
            {
                max = Math.Max(max, K1[i - 1] + K2[i + 1]);
            }

            return max;
        }
    }
}