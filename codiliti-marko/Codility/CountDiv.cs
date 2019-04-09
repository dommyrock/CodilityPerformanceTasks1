using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountDiv
    {
        //50%, O(B-A)
        public int solution(int A, int B, int K)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0) count++;
            }

            return count;
        }

        //100%
        public int solution2(int A, int B, int K)
        {
            int minDivisible = -1;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    minDivisible = i;
                    break;
                }
            }

            if (minDivisible == -1) return 0;
            return 1 + (B - minDivisible) / K;
        }
    }
}