using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class TieRopes
    {
        //100%, O(N)
        public int solution(int K, int[] A)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                if (sum >= K)
                {
                    count++;
                    sum = 0;
                }
            }

            return count;
        }
    }
}