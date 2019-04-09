using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class ChocolatesByNumbers
    {
        //75%
        public int solution(int N, int M)
        {
            HashSet<int> eaten = new HashSet<int>();

            int index = 0;
            while (true)
            {
                if (eaten.Contains(index)) return eaten.Count;

                eaten.Add(index);
                index = (index + M) % N;
            }
        }

        //100%, O(log(N + M))
        public int solution2(int N, int M)
        {
            int divisor = gcd(N, M);
            long multiple = (long)N * M / divisor;

            return (int)(multiple / M);
        }

        private int gcd(int a, int b)
        {
            if (a % b == 0) return b;
            else return gcd(b, a % b);
        }
    }
}