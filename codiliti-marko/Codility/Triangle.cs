using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Triangle
    {
        //62%, O(N**3)
        public int solution(int[] A)
        {
            int[] sorted = A.OrderBy(item => item).ToArray();

            bool nadjen = false;
            for (int i = 0; i < sorted.Length - 2; i++)
            {
                for (int j = i + 1; j < sorted.Length - 1; j++)
                {
                    for (int k = j + 1; k < sorted.Length; k++)
                    {
                        if (IsTriangle(sorted[i], sorted[j], sorted[k]))
                        {
                            nadjen = true;
                            break;
                        }
                    }
                    if (nadjen) break;
                }
                if (nadjen) break;
            }

            return nadjen ? 1 : 0;
        }

        //100%, O(N* log(N))
        public int solution2(int[] A)
        {
            int[] sorted = A.OrderBy(item => item).ToArray();

            for (int i = 0; i < sorted.Length - 2; i++)
            {
                if (IsTriangle(sorted[i], sorted[i + 1], sorted[i + 2]))
                {
                    return 1;
                }
            }

            return 0;
        }

        private bool IsTriangle(long a, long b, long c)
        {
            if (a + b <= c) return false;
            if (b + c <= a) return false;
            if (a + c <= b) return false;
            return true;
        }
    }
}