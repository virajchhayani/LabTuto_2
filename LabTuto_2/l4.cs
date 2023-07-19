using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l4
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            // Input two numbers A and B
            int A = 11;
            double B = 10.5;

            // Addition
            int sum = A + (int)B;
            Console.WriteLine("Sum: " + sum);

            // Subtraction
            double difference = A - B;
            Console.WriteLine("Difference: " + difference);

            // Multiplication
            int product = A * (int)B;
            Console.WriteLine("Product: " + product);

            // Division
            double quotient = A / B;
            Console.WriteLine("Quotient: " + quotient);

            // Modulus (remainder)
            int modulus = A % (int)B;
            Console.WriteLine("Modulus: " + modulus);

            // Increment
            A++;
            Console.WriteLine("Increment A: " + A);

            // Decrement
            B--;
            Console.WriteLine("Decrement B: " + B);

            // Relational operators
            bool isAGreater = A > (int)B;
            Console.WriteLine("Is A greater than B ? " + isAGreater);

            bool isBEqual = Math.Abs(B - 10.5) < 0.0001;
            Console.WriteLine("Is B equal to 10.5 ? " + isBEqual);

            // Logical operators
            bool logicalAnd = isAGreater && isBEqual;
            Console.WriteLine("Logical AND: " + logicalAnd);

            bool logicalOr = isAGreater || isBEqual;
            Console.WriteLine("Logical OR: " + logicalOr);

            bool logicalNot = !isAGreater;
            Console.WriteLine("Logical NOT: " + logicalNot);
        }
    }
}
