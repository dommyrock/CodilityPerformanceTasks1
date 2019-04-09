using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class ArrayInversionCount
    {
        //63%, O(N**2)
        public int solution(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j]) count++;
                    if (count > 1000000000) return -1;
                }
            }

            return count;
        }

        //100%, O(N*log(N)), moja implementacija rješenja s neta
        public int solution2(int[] A)
        {
            return mergeSort(A);
        }

        private int mergeSort(int[] A)
        {
            int inversionCount = 0;
            if (A.Length > 1)
            {
                int mid = A.Length / 2;

                int[] leftHalf = new int[mid];
                int[] rightHalf = new int[A.Length - mid];
                Array.Copy(A, 0, leftHalf, 0, leftHalf.Length);
                Array.Copy(A, mid, rightHalf, 0, rightHalf.Length);

                inversionCount += mergeSort(leftHalf);
                inversionCount += mergeSort(rightHalf);
                if (inversionCount > 1000000000) return -1;

                int i = 0;
                int j = 0;
                int k = 0;

                while (i < leftHalf.Length && j < rightHalf.Length)
                {
                    if (leftHalf[i] <= rightHalf[j])
                    {
                        A[k] = leftHalf[i];
                        i++;
                    }
                    else
                    {
                        A[k] = rightHalf[j];
                        j++;
                        inversionCount += leftHalf.Length - i;
                        if (inversionCount > 1000000000) return -1;
                    }
                    k++;
                }

                while (i < leftHalf.Length)
                {
                    A[k] = leftHalf[i];
                    i++;
                    k++;
                }

                while (j < rightHalf.Length)
                {
                    A[k] = rightHalf[j];
                    j++;
                    k++;
                }
            }

            return inversionCount;
        }
    }
}