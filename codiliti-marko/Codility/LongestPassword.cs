using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility
{
    public class LongestPassword
    {
        public int solution(string S)
        {
            string[] passwords = S.Split(' ');

            int min = -1;
            foreach (string password in passwords)
            {
                int validCharsCount = Regex.Matches(password, @"[a-zA-Z0-9]").Count;
                int lettersCount = Regex.Matches(password, @"[a-zA-Z]").Count;
                int digitsCount = Regex.Matches(password, @"[0-9]").Count;

                bool passwordValid = validCharsCount == password.Length && lettersCount % 2 == 0 && digitsCount % 2 == 1;
                if (passwordValid && password.Length > min) min = password.Length;
            }

            return min;
        }
    }
}