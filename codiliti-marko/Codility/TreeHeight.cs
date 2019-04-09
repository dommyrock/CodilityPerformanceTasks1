using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };

    public class TreeHeight
    {
        public int solution(Tree T)
        {
            return getHeight(T, 0);
        }

        private int getHeight(Tree t, int height)
        {
            if (t.l == null && t.r == null) return height;

            int leftHeight = 0;
            int rightHeight = 0;
            if (t.l != null) leftHeight = getHeight(t.l, height + 1);
            if (t.r != null) rightHeight = getHeight(t.r, height + 1);

            return Math.Max(leftHeight, rightHeight);
        }
    }
}