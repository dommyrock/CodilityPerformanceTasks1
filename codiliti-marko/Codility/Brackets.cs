using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Brackets
    {
        //100%, O(N)
        public int solution(string S)
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                {'}', '{'},
                {']', '['},
                {')', '('}
            };

            Stack<char> stack = new Stack<char>();
            foreach (char c in S)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return 0;
                    char popped = stack.Pop();
                    if (popped != pairs[c]) return 0;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}