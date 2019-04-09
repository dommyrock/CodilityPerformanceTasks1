using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Kruno2
    {
        public string solution(string s)
        {
            while (true)
            {
                string beginString = s;

                s = s.Replace("AA", "");
                s = s.Replace("BB", "");
                s = s.Replace("CC", "");

                if (s == beginString) return s;
            }
        }

        public string solution2(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && stack.Peek() == c) stack.Pop();
                else stack.Push(c);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return new string(sb.ToString().Reverse().ToArray());
        }

        public void run()
        {
            var result = solution2("ACCAABBC");
            Console.WriteLine(result);

            result = solution2("ABCBBCBA");
            Console.WriteLine(result);

            result = solution2("BABABA");
            Console.WriteLine(result);

            result = solution2("");
            Console.WriteLine(result);
        }
    }
}