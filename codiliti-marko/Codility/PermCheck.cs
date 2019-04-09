using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);
            for (int i = 1; i <= A.Length; i++)
            {
                if (!set.Contains(i)) return 0;
            }

            return 1;
        }
    }
}