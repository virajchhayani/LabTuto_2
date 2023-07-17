using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _9
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original Array:");
            DisplayArray(array);
            Console.Write("Enter the position to delete (0-indexed): ");
            int position = int.Parse(Console.ReadLine());
            if (position >= 0 && position < array.Length)
            {
                int[] newArray = new int[array.Length - 1];
                Array.Copy(array, 0, newArray, 0, position);
                Array.Copy(array, position + 1, newArray, position, array.Length - position - 1);
                Console.WriteLine("Modified Array:");
                DisplayArray(newArray);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
            Console.ReadLine();
        }
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
