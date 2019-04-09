using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinPerimeterRectangle
    {
        //100%, O(sqrt(N))
        public int solution(int N)
        {
            HashSet<int> djelitelji = new HashSet<int>();
            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0) djelitelji.Add(i);
            }

            int min = int.MaxValue;
            foreach (int a in djelitelji)
            {
                int b = N / a;
                int perimeter = 2 * (a + b);
                if (perimeter < min) min = perimeter;
            }

            return min;
        }
    }
}