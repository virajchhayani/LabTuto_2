using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Console.WriteLine("---------------------");
            // Problem 1: Find the other two numbers
            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            int[] result1 = FindDistinctNumbers(arr1);
            Console.WriteLine(string.Join(" ", result1)); // Output: 3 4
            Console.WriteLine("---------------------");
            int[] arr2 = { 2, 1, 3, 2 };
            int[] result2 = FindDistinctNumbers(arr2);
            Console.WriteLine(string.Join(" ", result2)); // Output: 1 3

            // Problem 2: Search for an element in a sorted matrix
            int[,] matrix = {
                { 3, 30, 38 },
                { 44, 52, 54 },
                { 57, 60, 69 }
            };
            Console.WriteLine("---------------------");
            int target1 = 62;
            Console.WriteLine(matSearch(matrix, matrix.GetLength(0), matrix.GetLength(1), target1)); // Output: 0

            int[,] matrix2 = {
                { 18, 21, 27, 38, 55, 67 }
            };
            Console.WriteLine("---------------------");
            int target2 = 55;
            Console.WriteLine(matSearch(matrix2, matrix2.GetLength(0), matrix2.GetLength(1), target2)); // Output: 1
        }
        // Problem 1: Find the other two numbers
        public static int[] FindDistinctNumbers(int[] arr)
        {
            int[] result = new int[2];
            int xor = 0;
            foreach (int num in arr)
                xor ^= num;
            int rightmostSetBit = xor & -xor;
            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                    result[0] ^= num;
                else
                    result[1] ^= num;
            }
            Array.Sort(result);
            return result;
        }
        // Problem 2: Search for an element in a sorted matrix
        public static int matSearch(int[,] matrix, int N, int M, int X)
        {
            int row = 0;
            int col = M - 1;
            while (row < N && col >= 0)
            {
                if (matrix[row, col] == X)
                    return 1;
                else if (matrix[row, col] > X)
                    col--;
                else
                    row++;
            }
            return 0;
        }
    }
}
