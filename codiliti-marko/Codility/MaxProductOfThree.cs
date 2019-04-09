using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxProductOfThree
    {
        //prvo sam fulao jer sam zaboravio alternativni dio sa 2 negativna broja...
        public int solution(int[] A)
        {
            int[] sorted = A.OrderBy(item => item).ToArray();
            int max = sorted[sorted.Length - 1] * sorted[sorted.Length - 2] * sorted[sorted.Length - 3];

            int[] negatives = sorted.Where(item => item < 0).ToArray();
            int[] positives = sorted.Where(item => item >= 0).ToArray();
            if (negatives.Length >= 2 && positives.Length > 0)
            {
                int alternative = negatives[0] * negatives[1] * positives[positives.Length - 1];
                if (alternative > max) max = alternative;
            }

            return max;
        }
    }
}