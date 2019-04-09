using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountDistinctSlices
    {
        //70%, O(N * (N + M))
        public int solution(int M, int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                HashSet<int> set = new HashSet<int>();
                for (int j = i; j < A.Length; j++)
                {
                    if (!set.Contains(A[j]))
                    {
                        count++;
                        if (count >= 1000000000) return 1000000000;
                        set.Add(A[j]);
                    }
                    else break;
                }
            }

            return count;
        }

        //100%, O(N)
        public int solution2(int M, int[] A)
        {
            int front = 0;
            int count = A.Length;
            HashSet<int> set = new HashSet<int>();
            for (int back = 0; back < A.Length - 1; back++)
            {
                while (front < A.Length && !set.Contains(A[front]))
                {
                    set.Add(A[front]);
                    front++;
                }

                count += set.Count - 1;
                if (count >= 1000000000) return 1000000000;

                set.Remove(A[back]);
            }

            return count;
        }
    }
}