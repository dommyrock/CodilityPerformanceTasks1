using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAbsSum
    {
        //54%, O(N**2 * max(abs(A)))
        public int solution(int[] A)
        {
            return function(A, new int[A.Length], 0);
        }

        private int function(int[] A, int[] S, int index)
        {
            if (index == A.Length)
            {
                int sum = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * S[i];
                }
                sum = Math.Abs(sum);
                return sum;
            }
            else
            {
                S[index] = 1;
                int sum1 = function(A, S, index + 1);

                S[index] = -1;
                int sum2 = function(A, S, index + 1);

                return Math.Min(sum1, sum2);
            }
        }

        //54%, O(N**2 * max(abs(A))), cachiranje sume nije pomoglo :)
        public int solution2(int[] A)
        {
            return function2(A, new int[A.Length], 0, 0);
        }

        private int function2(int[] A, int[] S, int index, int currentSum)
        {
            if (index == A.Length)
            {
                return Math.Abs(currentSum);
            }
            else
            {
                S[index] = 1;
                int sum1 = function2(A, S, index + 1, currentSum + A[index]);

                S[index] = -1;
                int sum2 = function2(A, S, index + 1, currentSum - A[index]);

                return Math.Min(sum1, sum2);
            }
        }
    }
}