using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Fish
    {
        //50%, O(N ** 2)
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    bool survive = true;
                    int maxMyWay = A[i];
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (B[j] == 1 && A[j] > maxMyWay) maxMyWay = A[j];
                        if (B[j] == 0 && A[j] > maxMyWay) survive = false;
                    }
                    if (survive) count++;
                }
                else
                {
                    bool survive = true;
                    int maxMyWay = A[i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (B[j] == 0 && A[j] > maxMyWay) maxMyWay = A[j];
                        if (B[j] == 1 && A[j] > maxMyWay) survive = false;
                    }
                    if (survive) count++;
                }
            }

            return count;
        }

        //100%, O(N)
        public int solution2(int[] A, int[] B)
        {
            int count = 0;
            Stack<int> downstreamSurvivals = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0)
                {
                    while (downstreamSurvivals.Count > 0 && downstreamSurvivals.Peek() < A[i])
                    {
                        downstreamSurvivals.Pop();
                    }
                    if (downstreamSurvivals.Count == 0) count++;
                }
                else
                {
                    downstreamSurvivals.Push(A[i]);
                }
            }

            return count + downstreamSurvivals.Count();
        }
    }
}