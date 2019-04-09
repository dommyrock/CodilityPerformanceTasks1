using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class NumberSolitaire
    {
        //100%, O(N)
        public int solution(int[] A)
        {
            int[] result = Enumerable.Repeat(int.MinValue, A.Length).ToArray();
            result[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (i - j >= 0)
                    {
                        int newResult = result[i - j] + A[i];
                        int oldResult = result[i];
                        if (newResult > oldResult) result[i] = newResult;
                    }
                }
            }

            return result[result.Length - 1];
        }
    }
}