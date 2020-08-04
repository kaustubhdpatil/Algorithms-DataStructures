using System;

namespace Sorts
{
    public class QuickSort : ISortable
    {
        public int[] Sort(int[] arrayToSort)
        {
            if (arrayToSort.Length > 1)
            {
                this.Sort(arrayToSort, 0, arrayToSort.Length - 1);
            }

            return arrayToSort;
        }

        private void Sort(int[] arrayToSort, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            // select the pivot element
            int pivot = arrayToSort[(right + left) / 2];
            
            // Partition the array using the pivot
            int index = this.Partition(arrayToSort, left, right, pivot);
            this.Sort(arrayToSort, left, index - 1);
            this.Sort(arrayToSort, index, right);
        }

        private int Partition(int[] arrayToSort, int left, int right, int pivot)
        {
            while (left <= right)
            {
                // Increment left until less than pivot
                while (arrayToSort[left] < pivot)
                {
                    left++;
                }

                // Decrement right until greater than or equal to pivot
                while (arrayToSort[right] > pivot)
                {
                    right--;
                }

                // If left is less than right perform the swap and increment left
                // decrement right
                if (left <= right)
                {
                    // Swap the numbers
                    this.Swap(arrayToSort, left, right);
                    left++;
                    right--;
                }
            }
            // return the left index as that represents the index to parition at
            return left;
        }

        private void Swap(int[] arrayToSort, int left, int right)
        {
            int temp = arrayToSort[left];
            arrayToSort[left] = arrayToSort[right];
            arrayToSort[right] = temp;
        }
    }
}