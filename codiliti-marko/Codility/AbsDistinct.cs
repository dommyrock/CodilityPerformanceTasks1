using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class AbsDistinct
    {
        //100%, O(N) or O(N*log(N))
        public int solution(int[] A)
        {
            //treba cast u long jer može doći int.MinValue a on se ne može staviti u Math.Abs sa intom
            return A.Select(item => Math.Abs((long)item)).Distinct().Count();
        }

        //100%, O(N) or O(N*log(N))
        public int solution2(int[] A)
        {
            HashSet<long> set = new HashSet<long>();
            foreach (long a in A)
            {
                set.Add(Math.Abs(a));
            }
            return set.Count();
        }
    }
}