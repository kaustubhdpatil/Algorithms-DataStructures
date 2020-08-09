using System;

namespace Sorts
{
    class Program
    {
        static void PrintResult(int[] array) 
        {
            int index = 0;

            while (index < array.Length)
            {
                Console.Write(array[index]);
                Console.Write(index < array.Length - 1 ? " " : string.Empty);
                index++;
            }
        }

        static void ReadAndSortArray(int totalNumbers)
        {
            ISortable sortable = null;

            Console.WriteLine("Select the type of sort");
            Console.WriteLine("1 - Quick Sort");
            Console.WriteLine("2 - Merge Sort");

            if (Console.ReadLine() == "1")
            {
                sortable = new QuickSort();
            }
            else
            {
                sortable = new MergeSort();
            }

            int[] inputArray = new int[totalNumbers];
            int index = 0;
            Console.WriteLine("Enter the integer values of the array");

            while (index < totalNumbers)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    inputArray[index] = value;
                    index++;
                }
                else
                {
                    Console.WriteLine("Enter a valid integer value");
                }
            }

            try
            {
                int[] result = new int[inputArray.Length];

                Console.WriteLine("Sorting...");
                result = sortable.Sort(inputArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                PrintResult(inputArray);
            }
        }

        static void ReadData()
        {
            Console.WriteLine("Enter the count of the numbers to be sorted");
            string enteredValue = Console.ReadLine();
            int.TryParse(enteredValue, out int totalNumbers);

            if (totalNumbers > 0)
            {
                ReadAndSortArray(totalNumbers);
            }
            else
            {
                Console.WriteLine("Enter a valid integer value.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Empty.PadLeft(25, '='));
            Console.WriteLine("Welcome to sorting");
            Console.WriteLine(string.Empty.PadLeft(25, '='));
            ReadData();
            Console.ReadKey();
        }
    }
}
