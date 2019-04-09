using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxProfit
    {
        //66%, O(N**2)
        public int solution(int[] A)
        {
            int max = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] - A[i] > max) max = A[j] - A[i];
                }
            }

            return max;
        }

        //100%, O(N)
        public int solution2(int[] A)
        {
            int maxProfit = 0;
            int minValue = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < minValue) minValue = A[i];
                else
                {
                    int profit = A[i] - minValue;
                    if (profit > maxProfit) maxProfit = profit;
                }
            }

            return maxProfit;
        }
    }
}