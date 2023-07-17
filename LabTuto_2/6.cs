using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _6
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] numbers = { 5, 2, 10, 0, 1, 8, 500, 6 };
            int min = FindMin(numbers);
            int max = FindMax(numbers);
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Maximum element: " + max);
        }
        static int FindMin(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("The array must contain at least one element.");
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        static int FindMax(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("The array must contain at least one element.");
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
    }
}
