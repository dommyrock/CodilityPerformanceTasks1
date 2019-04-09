using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Demo
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);
            int min = 1;

            while (true)
            {
                if (!set.Contains(min)) return min;
                min++;
            }
        }
    }
}