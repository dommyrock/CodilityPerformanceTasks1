using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountFactors
    {
        //71%, O(N)
        public int solution(int N)
        {
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0) count++;
            }

            return count;
        }

        //100%, O(sqrt(N))
        public int solution2(int N)
        {
            int count = 0;
            for (long i = 1; i * i <= N; i++)
            {
                if (N % i == 0) count += 2;
                if (i * i == N) count--;
            }

            return count;
        }
    }
}