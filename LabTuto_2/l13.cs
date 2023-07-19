using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Console.WriteLine("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            CalculateNotes(amount);
        }
        public static void CalculateNotes(int amount)
        {
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] count = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (amount >= notes[i])
                {
                    count[i] = amount / notes[i];
                    amount %= notes[i];
                }
            }
            Console.WriteLine("Minimum number of notes:");
            for (int i = 0; i < 10; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine("Notes of Rs." + notes[i] + " = " + count[i]);
                }
            }
        }
    }
}
