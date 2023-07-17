using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] elements = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements stored in the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
