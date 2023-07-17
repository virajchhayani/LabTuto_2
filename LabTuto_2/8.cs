using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _8
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] numbers = { 5, 2, 9, 1, 3 };
            Console.WriteLine("Original array:");
            PrintArray(numbers);
            Array.Sort(numbers, new DescendingComparer());
            Console.WriteLine("\nArray sorted in descending order:");
            PrintArray(numbers);
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
    class DescendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}