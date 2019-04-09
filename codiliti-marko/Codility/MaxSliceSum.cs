using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxSliceSum
    {
        //53%, O(N), ne radi za negativne brojeve
        public int solution(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;
            for (int i = 0; i < A.Length; i++)
            {
                maxEnding = Math.Max(0, maxEnding + A[i]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }

        //100%, O(N)
        public int solution2(int[] A)
        {
            int max = A.Max();
            if (max < 0) return max;

            int maxEnding = 0;
            int maxSlice = 0;
            for (int i = 0; i < A.Length; i++)
            {
                maxEnding = Math.Max(0, maxEnding + A[i]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }

        //100%, O(N), prema rješenju s interneta (pametnije s negativnim brojevima)
        public int solution3(int[] A)
        {
            int maxEnding = -1000000;   //mora biti baš tako, ne smije biti int.MinValue
            int maxSlice = -1000000;    //mora biti baš tako, ne smije biti int.MinValue
            for (int i = 0; i < A.Length; i++)
            {
                maxEnding = Math.Max(A[i], maxEnding + A[i]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}