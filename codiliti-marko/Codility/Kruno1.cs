using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility
{
    public class Kruno1
    {
        public int solution(string[] T, string[] R)
        {
            Dictionary<string, bool> groupHasNegativesDictionary = new Dictionary<string, bool>();
            for (int i = 0; i < T.Length; i++)
            {
                bool isNegative = R[i] != "OK";
                Regex regex = new Regex(@"([^\d]*\d+).*");

                Match match = regex.Match(T[i]);
                string group = match.Groups[1].Value;

                if (!groupHasNegativesDictionary.ContainsKey(group)) groupHasNegativesDictionary.Add(group, false);
                if (isNegative) groupHasNegativesDictionary[group] = true;
            }

            int positiveCount = 0;
            foreach (string key in groupHasNegativesDictionary.Keys)
            {
                if (!groupHasNegativesDictionary[key]) positiveCount++;
            }

            int result = positiveCount * 100 / groupHasNegativesDictionary.Keys.Count;
            return result;
        }

        public void run()
        {
            var result = solution(new string[] { "test1a", "test2", "test1b", "test1c", "test3" },
                new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded" });
            Console.WriteLine(result);

            result = solution(new string[] { "codility1", "codility3", "codility2", "codility4b", "codility4a" },
                new string[] { "Wrong answer", "OK", "OK", "Runtime error", "OK" });
            Console.WriteLine(result);
        }
    }
}