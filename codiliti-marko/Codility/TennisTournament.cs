using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class TennisTournament
    {
        public int solution(int P, int C)
        {
            return Math.Min(P / 2, C);
        }
    }
}