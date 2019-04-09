using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MergeSort
    {
        public void sort(int[] A)
        {
            mergeSort(A);
        }

        private void mergeSort(int[] A)
        {
            if (A.Length == 1) return;
            int mid = A.Length / 2;

            int[] leftHalf = new int[mid];
            int[] rightHalf = new int[A.Length - mid];
            Array.Copy(A, 0, leftHalf, 0, leftHalf.Length);
            Array.Copy(A, mid, rightHalf, 0, rightHalf.Length);

            mergeSort(leftHalf);
            mergeSort(rightHalf);

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
    }
}