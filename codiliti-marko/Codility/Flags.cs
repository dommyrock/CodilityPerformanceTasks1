using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Flags
    {
        //66%
        public int solution(int[] A)
        {
            List<int> peaks = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) peaks.Add(i);
            }

            int max = 0;
            for (int i = 1; i <= peaks.Count; i++)
            {
                int count = 0;
                int previousPeak = -1;
                foreach (int peakIndex in peaks)
                {
                    if (previousPeak == -1 || peakIndex - previousPeak >= i)
                    {
                        previousPeak = peakIndex;
                        count++;
                        if (count >= i) break;
                    }
                }

                if (count > max) max = count;
            }

            return max;
        }

        //100%, O(N)
        public int solution2(int[] A)
        {
            List<int> peaks = new List<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) peaks.Add(i);
            }

            int max = 0;
            for (int i = 1; i <= peaks.Count; i++)
            {
                int count = 0;
                int previousPeak = -1;
                foreach (int peakIndex in peaks)
                {
                    if (previousPeak == -1 || peakIndex - previousPeak >= i)
                    {
                        previousPeak = peakIndex;
                        count++;
                        if (count >= i) break;
                    }
                }

                if (count > max) max = count;

                if (max * i > A.Length) break;  //ako sa odabranim brojem zastava neću moći postaviti više od max zastava prekini
            }

            return max;
        }
    }
}