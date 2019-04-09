using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxNonoverlappingSegments
    {
        //100%, O(N)
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            int ending = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > ending)
                {
                    count++;
                    ending = B[i];
                }
            }

            return count;
        }
    }
}