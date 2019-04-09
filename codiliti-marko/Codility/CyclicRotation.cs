using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                B[(i + K) % A.Length] = A[i];
            }

            return B;
        }
    }
}