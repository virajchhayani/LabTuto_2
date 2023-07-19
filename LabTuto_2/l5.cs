using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements: {0}", sum);
            Console.Read();
        }
    }
}
