using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Console.Write("Input the marks obtained in Maths: ");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = mathMarks + physicsMarks + chemistryMarks;

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (totalMarks >= 180 || (mathMarks + physicsMarks) >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
