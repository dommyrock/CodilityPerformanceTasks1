using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Peaks
    {
        //100%, O(N * log(log(N)))
        public int solution(int[] A)
        {
            int[] numberOfPeaks = new int[A.Length];
            numberOfPeaks[0] = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) numberOfPeaks[i] = numberOfPeaks[i - 1] + 1;
                else numberOfPeaks[i] = numberOfPeaks[i - 1];
            }
            if (A.Length - 2 > 0) numberOfPeaks[A.Length - 1] = numberOfPeaks[A.Length - 2];

            int blockNum = 1;
            int result = 0;
            while (blockNum <= A.Length)
            {
                if (A.Length % blockNum == 0)
                {
                    int k = A.Length / blockNum;

                    bool hasAllPeaks = true;
                    for (int i = 0; i < blockNum; i++)
                    {
                        int startIndex = i * k;
                        int endIndex = i * k + k - 1;

                        bool hasPeak = false;
                        if (startIndex == 0) hasPeak = numberOfPeaks[endIndex] > 0;
                        else if (numberOfPeaks[endIndex] != numberOfPeaks[startIndex - 1]) hasPeak = true;

                        if (!hasPeak)
                        {
                            hasAllPeaks = false;
                            break;
                        }
                    }

                    if (hasAllPeaks) result = blockNum;
                }

                blockNum++;
            }

            return result;
        }
    }
}