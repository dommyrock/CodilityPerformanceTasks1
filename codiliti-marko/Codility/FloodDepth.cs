using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FloodDepth
    {
        public int solution(int[] A)
        {
            int max = 0;
            int min = 0;

            int maxDiff = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i > 0 && A[i] > A[i - 1])
                {
                    int diff = Math.Min(A[i], max) - min;
                    if (diff > maxDiff) maxDiff = diff;
                }

                if (A[i] > max)
                {
                    max = A[i];
                    min = A[i];
                }
                if (A[i] < min) min = A[i];
            }

            return maxDiff;
        }
    }
}