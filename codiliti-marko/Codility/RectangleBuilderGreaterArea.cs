using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class RectangleBuilderGreaterArea
    {
        //76%, O(N**2)
        public int solution(int[] A, int X)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dictionary.ContainsKey(A[i])) dictionary.Add(A[i], 1);
                else dictionary[A[i]]++;
            }

            int[] pieces = dictionary.Keys.Where(item => dictionary[item] >= 2).ToArray();

            int count = 0;
            for (int i = 0; i < pieces.Length - 1; i++)
            {
                for (int j = i + 1; j < pieces.Length; j++)
                {
                    long area = (long)pieces[i] * pieces[j];
                    if (area >= X) count++;
                    if (count > 1000000000) return -1;
                }
            }

            int[] doublePieces = dictionary.Keys.Where(item => dictionary[item] >= 4).ToArray();
            for (int i = 0; i < doublePieces.Length; i++)
            {
                long area = (long)doublePieces[i] * doublePieces[i];
                if (area >= X) count++;
                if (count > 1000000000) return -1;
            }

            return count;
        }

        //100%, O(N * log(N))
        public int solution2(int[] A, int X)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dictionary.ContainsKey(A[i])) dictionary.Add(A[i], 1);
                else dictionary[A[i]]++;
            }

            int count = 0;
            int[] pieces = dictionary.Keys.Where(item => dictionary[item] >= 2).OrderBy(item => item).ToArray();
            if (pieces.Length > 1)
            {
                int j = 1;
                for (int i = 0; i < pieces.Length - 1; i++)
                {
                    if (j >= pieces.Length) j--;
                    while (j > i)
                    {
                        long area = (long)pieces[i] * pieces[j];
                        if (area > X) j--;
                        else break;
                    }
                    if (j <= i) j = i + 1;

                    while (j < pieces.Length)
                    {
                        long area = (long)pieces[i] * pieces[j];
                        if (area < X) j++;
                        else break;
                    }

                    count += pieces.Length - j;
                    if (count > 1000000000) return -1;
                }
            }

            int[] doublePieces = dictionary.Keys.Where(item => dictionary[item] >= 4).ToArray();
            for (int i = 0; i < doublePieces.Length; i++)
            {
                long area = (long)doublePieces[i] * doublePieces[i];
                if (area >= X) count++;
                if (count > 1000000000) return -1;
            }

            return count;
        }
    }
}