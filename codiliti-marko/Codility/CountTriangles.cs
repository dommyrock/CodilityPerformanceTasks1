using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountTriangles
    {
        //72%, O(N**3), pokušaj Caterpillara ali sam fulao poantu :)
        public int solution(int[] A)
        {
            A = A.OrderBy(item => item).ToArray();
            int count = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    int k = i + 2;
                    while (k < A.Length && A[i] + A[j] > A[k])
                    {
                        k++;
                    }

                    count += k - j - 1;
                }
            }

            return count;
        }

        //100%, O(N**2)
        public int solution2(int[] A)
        {
            A = A.OrderBy(item => item).ToArray();
            int count = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                int k = i + 2;
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    while (k < A.Length && A[i] + A[j] > A[k])
                    {
                        k++;
                    }

                    count += k - j - 1;
                }
            }

            return count;
        }
    }
}