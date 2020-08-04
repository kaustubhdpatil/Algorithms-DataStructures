using System;

namespace Sorts 
{
    public class MergeSort : ISortable
    {
        public int[] Sort(int[] inputArray) 
        {
            int[] auxArray = new int[inputArray.Length];
            this.Sort(inputArray, auxArray, 0, inputArray.Length - 1);
            return inputArray;
        }

        private void Sort(int[] inputArray, int[] auxArray, int left, int right)
        {
            if (left >= right) 
            {
                return;
            }

            // Calculate the mid to divide the input array
            int mid = left + (right - left) / 2;
            // Divide the left half of the input array
            this.Sort(inputArray, auxArray, left, mid);
            // Divide the right half of the input array
            this.Sort(inputArray, auxArray, mid + 1, right);
            // Merge the left and the right arrays and add it to the auxArray array
            this.Merge(inputArray, auxArray, left, mid, right);
        }

        private void Merge(int[] inputArray, int[] auxArray, int left, int mid, int right)
        {
            // copy the elements to the aux array
            for (int i = left; i <= right; i++) 
            {
                auxArray[i] = inputArray[i];
            }

            // perform the merge operation on comparison
            // get the start positions of the left and right sub arrays
            int leftSubArrayIndex = left, rightSubArrayIndex = mid + 1;
            int index = left;
            // Loop over the array and move the elements to the appropriate positions
            while(leftSubArrayIndex < mid + 1 && rightSubArrayIndex < right + 1)
            {
                if (auxArray[leftSubArrayIndex] < auxArray[rightSubArrayIndex])
                {
                    // Since the element in the left is smaller 
                    // add that before the right side element
                    inputArray[index] = auxArray[leftSubArrayIndex];
                    // Increment the left side pointer
                    leftSubArrayIndex++;
                }
                else
                {
                    // Since the element in the right is smaller
                    // add that before the left side of the element
                    inputArray[index] = auxArray[rightSubArrayIndex];
                    // Increment the right side pointer
                    rightSubArrayIndex++;
                }
                
                index++;
            }

            // Check if left side of the arrays finished earlier
            if (leftSubArrayIndex < mid + 1)
            {
                // Copy over all the elements in the result Array
                Array.Copy(auxArray, leftSubArrayIndex, inputArray, index, (mid + 1 - leftSubArrayIndex));
            }
            // Check if left side of the arrays finished earlier
            if (rightSubArrayIndex < right + 1)
            {
                // Copy over all the elements in the result Array
                Array.Copy(auxArray, rightSubArrayIndex, inputArray, index, (right - rightSubArrayIndex));
            }
        }
    }
}