using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxCounters
    {
        //O(N*M)
        public int[] solution(int N, int[] A)
        {
            int[] output = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > N)
                {
                    int max = output.Max();
                    for (int j = 0; j < output.Length; j++)
                    {
                        output[j] = max;
                    }
                }
                else
                {
                    output[A[i] - 1]++;
                }
            }

            return output;
        }

        //i dalje O(N*M)
        public int[] solution2(int N, int[] A)
        {
            int[] output = new int[N];

            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > N)
                {
                    max = output.Max();
                }
                else
                {
                    if (max > output[A[i] - 1]) output[A[i] - 1] = max;
                    output[A[i] - 1]++;
                }
            }

            for (int j = 0; j < output.Length; j++)
            {
                if (output[j] < max) output[j] = max;
            }

            return output;
        }

        //O(N + M)
        //finta: izbjeći max nad arrayom jer je max O(N)
        public int[] solution3(int N, int[] A)
        {
            int[] output = new int[N];

            int max = 0;
            int maxToSet = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > N)
                {
                    maxToSet = max;
                }
                else
                {
                    if (maxToSet > output[A[i] - 1]) output[A[i] - 1] = maxToSet;
                    output[A[i] - 1]++;
                    if (output[A[i] - 1] > max) max = output[A[i] - 1];
                }
            }

            for (int j = 0; j < output.Length; j++)
            {
                if (output[j] < maxToSet) output[j] = maxToSet;
            }

            return output;
        }
    }
}