using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAvgTwoSlice
    {
        //60%, O(N ** 2)
        public int solution(int[] A)
        {
            int[] sums = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0) sums[i] = A[i];
                else sums[i] = sums[i - 1] + A[i];
            }

            decimal minAvg = int.MaxValue;
            int minIndex = int.MaxValue;
            int maxIndex = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    int count = j - i + 1;
                    int sum = sums[j];
                    if (i > 0) sum = sums[j] - sums[i - 1];

                    decimal avg = 1.0m * sum / count;
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minIndex = i;
                        maxIndex = j;
                    }
                }
            }

            return minIndex;
        }

        //postoji matematički teorem koji kaže da će minimalni splice biti uvijek veličine 2 ili 3...
        public int solution2(int[] A)
        {
            int[] sums = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0) sums[i] = A[i];
                else sums[i] = sums[i - 1] + A[i];
            }

            decimal minAvg = int.MaxValue;
            int minIndex = int.MaxValue;
            int maxIndex = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < i + 3 && j < A.Length; j++)
                {
                    int count = j - i + 1;
                    int sum = sums[j];
                    if (i > 0) sum = sums[j] - sums[i - 1];

                    decimal avg = 1.0m * sum / count;
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minIndex = i;
                        maxIndex = j;
                    }
                }
            }

            return minIndex;
        }
    }
}