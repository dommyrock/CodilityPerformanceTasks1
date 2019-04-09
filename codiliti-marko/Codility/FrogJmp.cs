using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling(1.0 * (Y - X) / D);
        }
    }
}