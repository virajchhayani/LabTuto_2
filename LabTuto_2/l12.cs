using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] arr = { 2, 4, 6, 8, 10 };
            int element = 6;
            bool found = false;
            foreach (int num in arr)
            {
                if (num == element)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
