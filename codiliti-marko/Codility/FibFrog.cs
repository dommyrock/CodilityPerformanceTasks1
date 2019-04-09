using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FibFrog
    {
        //75%, O(N* log(N) ** N)
        public int solution(int[] A)
        {
            List<int> fibbNumbers = FibbNumbers(A.Length).OrderByDescending(item => item).ToList();
            fibbNumbers.RemoveAt(fibbNumbers.Count - 1);

            Stack<int> stack = new Stack<int>();
            Stack<int> bestStack = new Stack<int>();
            Solve(A, fibbNumbers, stack, -1, bestStack);
            if (bestStack.Count == 0) return -1;
            return bestStack.Count;
        }

        private bool Solve(int[] A, List<int> fibbNumbers, Stack<int> stack, int index, Stack<int> bestStack)
        {
            if (bestStack.Count != 0 && stack.Count >= bestStack.Count) return false;
            if (index > A.Length) return false;
            if (index == A.Length)
            {
                if (stack.Count < bestStack.Count || bestStack.Count == 0)
                {
                    bestStack.Clear();
                    foreach (int i in stack)
                    {
                        bestStack.Push(i);
                    }
                }

                return true;
            }
            if (index >= 0 && A[index] == 0) return false;

            bool result = false;
            foreach (int fibb in fibbNumbers)
            {
                stack.Push(fibb);
                bool b = Solve(A, fibbNumbers, stack, index + fibb, bestStack);
                if (b) result = b;
                stack.Pop();
            }
            return result;
        }

        private List<int> FibbNumbers(int n)
        {
            List<int> list = new List<int>();
            int i = 0;
            while (true)
            {
                double a = Math.Pow(((1 + Math.Sqrt(5.0)) / 2), i);
                double b = Math.Pow(((1 - Math.Sqrt(5.0)) / 2), i);

                int number = (int)Math.Round((a - b) / Math.Sqrt(5));
                list.Add(number);
                if (number > n) break;
                i++;
            }

            return list;
        }

        //100%, O(N * log(N)), rješenje sa dinamičkim programiranjem prema rješenju s neta
        public int solution2(int[] A)
        {
            List<int> list = A.ToList();
            list.Add(1);
            A = list.ToArray();

            List<int> fibbNumbers = FibbNumbers(A.Length);
            fibbNumbers.RemoveAt(0);
            fibbNumbers.RemoveAt(0);
            fibbNumbers.RemoveAt(fibbNumbers.Count - 1);

            int[] reachable = new int[A.Length];
            foreach (int fibb in fibbNumbers)
            {
                if (A[fibb - 1] == 1) reachable[fibb - 1] = 1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0 || reachable[i] > 0) continue;

                int minIndex = -1;
                int minValue = 100000;

                foreach (int fibb in fibbNumbers)
                {
                    if (i - fibb >= 0 && reachable[i - fibb] > 0 && minValue > reachable[i - fibb])
                    {
                        minValue = reachable[i - fibb];
                        minIndex = i - fibb;
                    }
                }
                if (minIndex != -1) reachable[i] = minValue + 1;
            }

            int result = reachable[A.Length - 1];
            return result > 0 ? result : -1;
        }
    }
}