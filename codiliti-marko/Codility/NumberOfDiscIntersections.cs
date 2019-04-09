using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class NumberOfDiscIntersections
    {
        //62%, O(N**2)
        public int solution(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (isIntersect(i, j, A[i], A[j])) count++;
                    if (count > 10000000) return -1;
                }
            }
            return count;
        }

        private bool isIntersect(int x1, int x2, int r1, int r2)
        {
            long left1 = x1 - r1;
            long right1 = x1 + r1;

            long left2 = x2 - r2;
            long right2 = x2 + r2;

            return right1 >= left2 || left1 >= right2;
        }

        //93%, O(N*log(N)) or O(N), ideja s neta, overflow faila
        public int solution2(int[] A)
        {
            int unclosed = 0;
            int count = 0;

            int startPosition = int.MaxValue;
            int endPosition = int.MinValue;

            long[] lefts = new long[A.Length];
            long[] rights = new long[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                lefts[i] = i - A[i];
                rights[i] = i + A[i];
                if (i - A[i] < startPosition) startPosition = i - A[i];
                if (i + A[i] > endPosition) endPosition = i + A[i];
            }

            long[] leftsSorted = lefts.OrderBy(item => item).ToArray();
            long[] rightsSorted = rights.OrderBy(item => item).ToArray();

            long leftIndex = 0;
            long rightIndex = 0;

            for (long i = startPosition; i <= endPosition; i++)
            {
                while (leftIndex < leftsSorted.Length && i == leftsSorted[leftIndex])
                {
                    unclosed++;
                    leftIndex++;
                }

                while (rightIndex < rightsSorted.Length && i == rightsSorted[rightIndex])
                {
                    unclosed--;
                    rightIndex++;

                    count += unclosed;
                    if (count > 10000000) return -1;
                }
            }

            return count;
        }

        private class Enpoint
        {
            public long X { get; set; }
            public bool IsOpening { get; set; }
        }

        //100%, O(N*log(N)) or O(N), ideja s neta i pregled koda s neta :(
        public int solution3(int[] A)
        {
            int unclosed = 0;
            int count = 0;

            List<Enpoint> endpoints = new List<Enpoint>();
            for (int i = 0; i < A.Length; i++)
            {
                endpoints.Add(new Enpoint { X = (long)i - A[i], IsOpening = true });
                endpoints.Add(new Enpoint { X = (long)i + A[i], IsOpening = false });
            }

            endpoints = endpoints.OrderBy(item => item.X).ThenBy(item => !item.IsOpening).ToList();

            foreach (Enpoint endpoint in endpoints)
            {
                if (endpoint.IsOpening)
                {
                    unclosed++;
                }
                else
                {
                    unclosed--;
                    count += unclosed;
                    if (count > 10000000) return -1;
                }
            }
            return count;
        }
    }
}