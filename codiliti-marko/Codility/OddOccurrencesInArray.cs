using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int item in A)
            {
                if (set.Contains(item)) set.Remove(item);
                else set.Add(item);
            }

            return set.ToList().FirstOrDefault();
        }
    }
}