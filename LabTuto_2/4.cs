using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _4
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[sourceArray.Length];
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);
            Console.WriteLine("Elements of destinationArray:");
            foreach (int element in destinationArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
