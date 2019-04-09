using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class StoneWall
    {
        //92%, O(N) or O(N**2)
        public int solution(int[] H)
        {
            int previous = -1;
            int count = 0;
            HashSet<int> previousHeights = new HashSet<int>();
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > previous)
                {
                    count++;
                    previousHeights.Add(H[i]);
                }
                else if (H[i] < previous)
                {
                    if (!previousHeights.Contains(H[i])) count++;

                    List<int> list = previousHeights.Where(item => item <= H[i]).ToList();
                    previousHeights = new HashSet<int>(list);
                    previousHeights.Add(H[i]);
                }

                previous = H[i];
            }

            return count;
        }

        //92%, O(N)
        public int solution2(int[] H)
        {
            int previous = -1;
            int count = 0;
            Stack<int> previousHeights = new Stack<int>();
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > previous)
                {
                    count++;
                    previousHeights.Push(H[i]);
                }
                else if (H[i] < previous)
                {
                    if (!previousHeights.Contains(H[i])) count++;

                    while (previousHeights.Count > 0 && previousHeights.Peek() > H[i])
                    {
                        previousHeights.Pop();
                    }

                    previousHeights.Push(H[i]);
                }

                previous = H[i];
            }

            return count;
        }

        //100%, O(N)
        public int solution3(int[] H)
        {
            int previous = -1;
            int count = 0;
            Stack<int> previousHeights = new Stack<int>();
            HashSet<int> previouesHeightsSet = new HashSet<int>();
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > previous)
                {
                    count++;
                    previousHeights.Push(H[i]);
                    previouesHeightsSet.Add(H[i]);
                }
                else if (H[i] < previous)
                {
                    if (!previouesHeightsSet.Contains(H[i])) count++;

                    while (previousHeights.Count > 0 && previousHeights.Peek() > H[i])
                    {
                        int popped = previousHeights.Pop();
                        previouesHeightsSet.Remove(popped);
                    }

                    previousHeights.Push(H[i]);
                    previouesHeightsSet.Add(H[i]);
                }

                previous = H[i];
            }

            return count;
        }

        //100%, O(N), nakon što sam vidio rješenje na netu sam uspio izbaciti hashset viška
        public int solution4(int[] H)
        {
            int previous = -1;
            int count = 0;
            Stack<int> previousHeights = new Stack<int>();
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > previous)
                {
                    count++;
                    previousHeights.Push(H[i]);
                }
                else if (H[i] < previous)
                {
                    while (previousHeights.Count > 0 && previousHeights.Peek() > H[i])
                    {
                        previousHeights.Pop();
                    }

                    if (previousHeights.Count == 0 || previousHeights.Peek() != H[i])
                    {
                        count++;
                        previousHeights.Push(H[i]);
                    }
                }

                previous = H[i];
            }

            return count;
        }
    }
}