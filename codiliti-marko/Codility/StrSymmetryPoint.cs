using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class StrSymmetryPoint
    {
        //100%, O(length(S))
        public int solution(string S)
        {
            if (S.Length % 2 == 0) return -1;

            string reversed = new string(S.Reverse().ToArray());
            if (reversed == S) return S.Length / 2;

            return -1;
        }
    }
}