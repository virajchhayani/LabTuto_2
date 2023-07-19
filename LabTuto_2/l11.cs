using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum of the elements in the array is: " + sum);
        }
    }
}
