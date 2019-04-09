using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class EquiLeader
    {
        //55%, O(N ** 2)
        public int solution(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    list.Add(A[j]);
                }

                int leader1 = GetLeader(list);

                list = new List<int>();
                for (int j = i + 1; j < A.Length; j++)
                {
                    list.Add(A[j]);
                }
                int leader2 = GetLeader(list);

                if (leader1 == leader2 && leader1 != -1) count++;
            }

            return count;
        }

        private int GetLeader(List<int> A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (!dictionary.ContainsKey(A[i])) dictionary[A[i]] = 1;
                else dictionary[A[i]]++;
            }

            int maxValue = 0;
            int maxKey = 0;
            foreach (int key in dictionary.Keys)
            {
                if (dictionary[key] > maxValue)
                {
                    maxValue = dictionary[key];
                    maxKey = key;
                }
            }

            if (2 * maxValue > A.Count) return maxKey;
            return -1;
        }

        //88%, O(N)
        public int solution2(int[] A)
        {
            Dictionary<int, int> leftDict = new Dictionary<int, int>();
            Dictionary<int, int> rightDict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!rightDict.ContainsKey(A[i])) rightDict[A[i]] = 1;
                else rightDict[A[i]]++;
            }

            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (!leftDict.ContainsKey(A[i])) leftDict[A[i]] = 1;
                else leftDict[A[i]]++;

                rightDict[A[i]]--;

                int leftArrayCount = i + 1;
                int leader = GetLeader2(leftDict, leftArrayCount);
                if (leader != -1)
                {
                    int rightArrayCount = A.Length - i - 1;
                    if (2 * rightDict[leader] > rightArrayCount) count++;
                }
            }

            return count;
        }

        private int GetLeader2(Dictionary<int, int> dictionary, int count)
        {
            int maxValue = 0;
            int maxKey = 0;
            foreach (int key in dictionary.Keys)
            {
                if (dictionary[key] > maxValue)
                {
                    maxValue = dictionary[key];
                    maxKey = key;
                }
            }

            if (2 * maxValue > count) return maxKey;
            return -1;
        }

        //100%, O(N)
        public int solution3(int[] A)
        {
            Dictionary<int, int> leftDict = new Dictionary<int, int>();
            Dictionary<int, int> rightDict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!rightDict.ContainsKey(A[i])) rightDict[A[i]] = 1;
                else rightDict[A[i]]++;
            }

            int count = 0;
            int previousLeader = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (!leftDict.ContainsKey(A[i])) leftDict[A[i]] = 1;
                else leftDict[A[i]]++;

                rightDict[A[i]]--;

                int leftArrayCount = i + 1;
                int leader = -1;
                if (2 * leftDict[A[i]] > leftArrayCount) leader = A[i]; //mogu ja biti leader
                if (previousLeader != -1 && 2 * leftDict[previousLeader] > leftArrayCount) leader = previousLeader; //ili može biti prethodni leader

                if (leader != -1)
                {
                    int rightArrayCount = A.Length - i - 1;
                    if (2 * rightDict[leader] > rightArrayCount) count++;
                }

                previousLeader = leader;
            }

            return count;
        }
    }
}