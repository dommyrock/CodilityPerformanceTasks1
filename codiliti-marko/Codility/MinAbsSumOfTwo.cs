using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAbsSumOfTwo
    {
        //45%, O(N * N)
        public int solution(int[] A)
        {
            int min = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < min) min = sum;
                }
            }

            return min;
        }

        //54%, O(N * N)
        public int solution2(int[] A)
        {
            A = A.OrderBy(item => item).ToArray();

            int min = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                int minSum = int.MaxValue;
                for (int j = i; j < A.Length; j++)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < minSum) minSum = sum;
                    else break;
                }
                if (minSum < min) min = minSum;
            }

            return min;
        }

        //90%, O(N * log(N)), 1 krivi odgovor
        public int solution3(int[] A)
        {
            A = A.OrderBy(item => item).ToArray();

            int min = int.MaxValue;
            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (j < i) j = i;
                bool mijenjan = false;
                int minCurrent = int.MaxValue;
                while (j > i)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < minCurrent)
                    {
                        minCurrent = sum;
                        j--;
                        mijenjan = true;
                    }
                    else break;
                }
                if (mijenjan) j++;

                mijenjan = false;
                while (j < A.Length)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < minCurrent)
                    {
                        minCurrent = sum;
                        j++;
                        mijenjan = true;
                    }
                    else break;
                }
                if (mijenjan) j--;

                if (minCurrent < min) min = minCurrent;
            }

            return min;
        }

        //90%, O(N * log(N)), 1 krivi odgovor
        public int solution4(int[] A)
        {
            A = A.OrderBy(item => item).ToArray();

            int min = int.MaxValue;
            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (j < i) j = i;

                int minCurrent1 = int.MaxValue;
                while (j >= i)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < minCurrent1)
                    {
                        minCurrent1 = sum;
                        if (j == 0) break;
                        j--;
                    }
                    else break;
                }

                int minCurrent2 = int.MaxValue;
                while (j < A.Length)
                {
                    int sum = Math.Abs(A[i] + A[j]);
                    if (sum < minCurrent2)
                    {
                        minCurrent2 = sum;
                        if (j == A.Length - 1) break;
                        j++;
                    }
                    else break;
                }

                if (minCurrent1 < min) min = minCurrent1;
                if (minCurrent2 < min) min = minCurrent2;
            }

            return min;
        }

        //100%, O(N * log(N)), prema rješenju s neta
        public int solution5(int[] A)
        {
            int min = int.MaxValue;
            int front = 0;
            int back = A.Length - 1;

            A = A.OrderBy(item => item).ToArray();

            while (front <= back)
            {
                int sum = Math.Abs(A[front] + A[back]);
                if (sum < min) min = sum;

                if (Math.Abs(A[front]) > Math.Abs(A[back]))
                {
                    front++;
                }
                else
                {
                    back--;
                }
            }

            return min;
        }
    }
}