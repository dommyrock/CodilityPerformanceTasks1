using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);
            int i = 0;
            while (true)
            {
                i++;
                if (!set.Contains(i)) return i;
            }
        }
    }
}