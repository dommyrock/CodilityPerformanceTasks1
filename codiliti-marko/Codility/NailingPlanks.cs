using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class NailingPlanks
    {
        //62%, O(N * M)
        public int solution(int[] A, int[] B, int[] C)
        {
            int minNails = 0;
            int maxNails = C.Length;

            int result = -1;
            while (minNails <= maxNails)
            {
                int midNails = (minNails + maxNails) / 2;
                if (AreAllPlanksNailed(A, B, C, midNails))
                {
                    result = midNails;
                    maxNails = midNails - 1;
                }
                else
                {
                    minNails = midNails + 1;
                }
            }

            return result;
        }

        private bool AreAllPlanksNailed(int[] A, int[] B, int[] C, int numberOfNails)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool nailed = false;
                for (int j = 0; j < numberOfNails; j++)
                {
                    if (A[i] <= C[j] && C[j] <= B[i])
                    {
                        nailed = true;
                        break;
                    }
                }
                if (!nailed) return false;
            }

            return true;
        }

        //100%, O((N + M) * log(M))
        public int solution2(int[] A, int[] B, int[] C)
        {
            int minNails = 0;
            int maxNails = C.Length;

            int result = -1;
            while (minNails <= maxNails)
            {
                int midNails = (minNails + maxNails) / 2;
                if (AreAllPlanksNailed2(A, B, C, midNails))
                {
                    result = midNails;
                    maxNails = midNails - 1;
                }
                else
                {
                    minNails = midNails + 1;
                }
            }

            return result;
        }

        private bool AreAllPlanksNailed2(int[] A, int[] B, int[] C, int numberOfNails)
        {
            int[] nailsToUse = new int[numberOfNails];
            for (int i = 0; i < numberOfNails; i++)
            {
                nailsToUse[i] = C[i];
            }
            HashSet<int> nailsHashSet = new HashSet<int>(nailsToUse);

            int[] sums = new int[2 * C.Length + 1];
            sums[0] = 0;
            for (int i = 1; i < sums.Length; i++)
            {
                int increment = nailsHashSet.Contains(i) ? 1 : 0;
                sums[i] = sums[i - 1] + increment;
            }

            for (int i = 0; i < A.Length; i++)
            {
                bool nailed = sums[B[i]] != 0;
                if (A[i] - 1 >= 0) nailed = sums[A[i] - 1] != sums[B[i]];
                if (!nailed) return false;
            }

            return true;
        }
    }
}