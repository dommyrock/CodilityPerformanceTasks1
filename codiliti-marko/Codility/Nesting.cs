using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Nesting
    {
        //100%, O(N)
        public int solution(string S)
        {
            int count = 0;
            foreach (char c in S)
            {
                if (c == '(')
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count < 0) return 0;
                }
            }

            return count == 0 ? 1 : 0;
        }
    }
}