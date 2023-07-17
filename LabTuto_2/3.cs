using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _3
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Console.Write("Enter the number of values: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter the values:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Value {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values in reverse order are:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
