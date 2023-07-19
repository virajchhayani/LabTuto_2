using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] arr = { 1, 2, 3, 2, 1, 4 };
            int n = (arr.Length - 2) / 2;
            int[] result = FindDistinctNumbers(arr, n);
            Console.WriteLine(string.Join(" ", result));
        }
        private static int[] FindDistinctNumbers(int[] arr, int n)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            // Count the occurrences of each number
            foreach (int num in arr)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }
            int[] distinctNumbers = new int[2];
            int index = 0;
            // Find the numbers that occur exactly once
            foreach (KeyValuePair<int, int> entry in countMap)
            {
                if (entry.Value == 1)
                {
                    distinctNumbers[index] = entry.Key;
                    index++;
                    // Break if we have found both numbers
                    if (index == 2)
                        break;
                }
            }
            return distinctNumbers;
        }
    }
}
