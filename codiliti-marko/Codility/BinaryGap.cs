using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            int count = 0;
            int maxCount = 0;

            bool hasRightOne = false;
            while (N > 0)
            {
                if (N % 2 == 0)
                {
                    if (hasRightOne) count++;
                }
                else
                {
                    hasRightOne = true;
                    if (count > maxCount) maxCount = count;
                    count = 0;
                }
                N = N / 2;
            }

            return maxCount;
        }
    }
}