using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class TimeComplexity
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);

            for (int i = 1; i <= A.Length + 1; i++)
            {
                if (!set.Contains(i)) return i;
            }

            return 0;
        }
    }
}