using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                set.Add(A[i]);
                if (set.Count() == X) return i;
            }
            return -1;
        }
    }
}