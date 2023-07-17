using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _7
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers = new int[numbers.Length];
            int[] oddNumbers = new int[numbers.Length];
            int evenIndex = 0;
            int oddIndex = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[evenIndex] = number;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = number;
                    oddIndex++;
                }
            }
            Array.Resize(ref evenNumbers, evenIndex);
            Array.Resize(ref oddNumbers, oddIndex);

            Console.WriteLine("Even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write(evenNumber + " ");
            }
            Console.WriteLine("\nOdd numbers:");
            foreach (int oddNumber in oddNumbers)
            {
                Console.Write(oddNumber + " ");
            }
            Console.ReadLine();
        }
    }
}
