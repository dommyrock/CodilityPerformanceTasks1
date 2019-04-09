using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Dominator
    {
        //100%, O(N*log(N)) or O(N)
        public int solution(int[] A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dictionary.ContainsKey(A[i])) dictionary.Add(A[i], 1);
                else dictionary[A[i]]++;
            }

            int maxValue = int.MinValue;
            int maxKey = -1;
            foreach (int key in dictionary.Keys)
            {
                if (dictionary[key] > maxValue)
                {
                    maxValue = dictionary[key];
                    maxKey = key;
                }
            }

            if (2 * maxValue > A.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == maxKey) return i;
                }
            }
            return -1;
        }
    }
}