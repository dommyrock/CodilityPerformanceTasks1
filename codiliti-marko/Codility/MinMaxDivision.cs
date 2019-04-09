using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinMaxDivision
    {
        //100%, O(N*log(N+M)), moja implementacija prema rješenju s neta, nisam znao napisati svoje rješenje...
        public int solution(int K, int M, int[] A)
        {
            int min = A.Max();
            int max = A.Sum();

            int result = -1;
            while (min <= max)
            {
                int middle = (min + max) / 2;
                if (IsSumPossible(A, K, middle))
                {
                    result = middle;
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }

            return result;
        }

        private bool IsSumPossible(int[] A, int K, int sumToTest)
        {
            int numberOfBlocks = 1;
            int blockSum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (blockSum + A[i] <= sumToTest)
                {
                    blockSum += A[i];
                }
                else
                {
                    numberOfBlocks++;
                    blockSum = A[i];
                }

                if (numberOfBlocks > K) return false;
            }

            return true;
        }
    }
}