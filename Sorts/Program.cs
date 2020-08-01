using System;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadLeft(25, '='));
            Console.WriteLine("Welcome to sorting");
            Console.WriteLine("".PadLeft(25, '='));
            
            Console.WriteLine("Enter the count of the numbers to be sorted");
            string enteredValue = Console.ReadLine();
            int.TryParse(enteredValue, out int totalNumbers);

            if (totalNumbers > 0) {
                int [] inputArray = new int[totalNumbers];
                int index = 0;
                Console.WriteLine("Enter the integer values of the array");

                while (index < totalNumbers) {
                    if (int.TryParse(Console.ReadLine(), out int value)) {
                        inputArray[index] = value;
                        index++;
                    }
                    else {
                        Console.WriteLine("Enter a valid integer value");
                    }
                }

                ISortable sortable = new QuickSort();

                try
                {
                    Console.WriteLine("Sorting...");
                    sortable.Sort(inputArray);
                }
                catch(Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                
                index = 0;

                while (index < inputArray.Length)
                {
                    Console.Write(inputArray[index]);
                    Console.Write(index < inputArray.Length - 1 ? " " : string.Empty);
                    index++;
                }
            }
            else {
                Console.WriteLine("Enter a valid integer value.");
            }
            
            Console.ReadKey();
        }
    }
}
