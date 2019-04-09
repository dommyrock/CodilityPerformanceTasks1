using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int brojJedinica = A.Count(item => item == 1);

            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) result += brojJedinica;
                else brojJedinica--;

                if (result > 1000000000) return -1;
            }

            return result;
        }
    }
}