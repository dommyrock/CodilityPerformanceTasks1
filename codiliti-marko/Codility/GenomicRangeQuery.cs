using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class GenomicRangeQuery
    {
        //62%, presporo O(N*M)
        public int[] solution(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> impactDictionary = new Dictionary<char, int>
            {
                {'A', 1 },
                {'C', 2 },
                {'G', 3 },
                {'T', 4 }
            };

            int[] input = new int[S.Length];
            int index = 0;
            foreach (char c in S.ToCharArray())
            {
                input[index++] = impactDictionary[c];
            }

            int[] output = new int[P.Length];
            index = 0;
            for (int i = 0; i < P.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = P[i]; j <= Q[i]; j++)
                {
                    if (input[j] < min) min = input[j];
                }
                output[index++] = min;
            }

            return output;
        }

        //62%, O(N * M), OutOfMemory na težim primjerima
        public int[] solution2(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> impactDictionary = new Dictionary<char, int>
            {
                {'A', 1 },
                {'C', 2 },
                {'G', 3 },
                {'T', 4 }
            };

            int[] input = new int[S.Length];
            int index = 0;
            foreach (char c in S.ToCharArray())
            {
                input[index++] = impactDictionary[c];
            }

            int[,] data = new int[input.Length, input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int min = input[i];
                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < min) min = input[j];
                    data[i, j] = min;
                }
            }

            int[] output = new int[P.Length];
            index = 0;
            for (int i = 0; i < P.Length; i++)
            {
                output[index++] = data[P[i], Q[i]];
            }

            return output;
        }

        //75%, O(N * M)
        public int[] solution3(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> impactDictionary = new Dictionary<char, int>
            {
                {'A', 1 },
                {'C', 2 },
                {'G', 3 },
                {'T', 4 }
            };

            int[] input = new int[S.Length];
            int index = 0;
            foreach (char c in S.ToCharArray())
            {
                input[index++] = impactDictionary[c];
            }

            int[] starts = P.Select(item => item).Distinct().ToArray();

            Dictionary<int, int[]> data = new Dictionary<int, int[]>();

            foreach (int i in starts)
            {
                int[] array = new int[input.Length];
                int min = input[i];
                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < min) min = input[j];
                    array[j] = min;
                }
                data.Add(i, array);
            }

            int[] output = new int[P.Length];
            index = 0;
            for (int i = 0; i < P.Length; i++)
            {
                output[index++] = data[P[i]][Q[i]];
            }

            return output;
        }

        //100%, O(N + M), ideja sa interneta, a moja implementacija
        public int[] solution4(string S, int[] P, int[] Q)
        {
            Dictionary<char, int> impactDictionary = new Dictionary<char, int>
            {
                {'A', 1 },
                {'C', 2 },
                {'G', 3 },
                {'T', 4 }
            };

            Dictionary<int, List<int>> dataDictionary = new Dictionary<int, List<int>>()
            {
                { 1, new List<int>() },
                { 2, new List<int>() },
                { 3, new List<int>() },
                { 4, new List<int>() }
            };

            int[] input = new int[S.Length];
            int index = 0;
            foreach (char c in S.ToCharArray())
            {
                input[index] = impactDictionary[c];

                foreach (int key in dataDictionary.Keys)
                {
                    if (index == 0)
                    {
                        if (key == input[index]) dataDictionary[key].Add(1);
                        else dataDictionary[key].Add(0);
                    }
                    else
                    {
                        if (key == input[index]) dataDictionary[key].Add(dataDictionary[key][index - 1] + 1);
                        else dataDictionary[key].Add(dataDictionary[key][index - 1]);
                    }
                }

                index++;
            }

            int[] output = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    int beginValue = 0;
                    if (P[i] > 0) beginValue = dataDictionary[j][P[i] - 1];
                    int endValue = dataDictionary[j][Q[i]];

                    bool hasValue = endValue != beginValue;
                    if (hasValue)
                    {
                        output[i] = j;
                        break;
                    }
                }
            }

            return output;
        }
    }
}