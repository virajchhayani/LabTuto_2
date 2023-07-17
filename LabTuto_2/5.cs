using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class _5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 8, 7, 5, 2, 1 };
            Dictionary<int, int> countDictionary = CountDuplicates(numbers);
            foreach (var kvp in countDictionary)
            {
                Console.WriteLine($"Number {kvp.Key} has {kvp.Value} occurrences");
            }
        }
        static Dictionary<int, int> CountDuplicates(int[] numbers)
        {
            Dictionary<int, int> countDictionary = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (countDictionary.ContainsKey(number))
                {
                    countDictionary[number]++;
                }
                else
                {
                    countDictionary[number] = 1;
                }
            }
            return countDictionary;
        }
    }
}
