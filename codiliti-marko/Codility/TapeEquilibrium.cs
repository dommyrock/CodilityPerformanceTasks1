using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class TapeEquilibrium
    {
        //sporo O(N2)
        public int solution(int[] A)
        {
            int min = int.MaxValue;
            for (int index = 1; index < A.Length; index++)
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int j = 0; j < A.Length; j++)
                {
                    if (j < index) sum1 += A[j];
                    else sum2 += A[j];
                }

                int diff = Math.Abs(sum1 - sum2);
                if (diff < min) min = diff;
            }

            return min;
        }

        //brzo
        public int solution2(int[] A)
        {
            int sum1 = A[0];
            int sum2 = A.Sum() - sum1;

            int min = Math.Abs(sum1 - sum2);

            for (int i = 1; i < A.Length - 1; i++)
            {
                sum1 += A[i];
                sum2 -= A[i];

                int diff = Math.Abs(sum1 - sum2);
                if (diff < min) min = diff;
            }

            return min;
        }
    }
}