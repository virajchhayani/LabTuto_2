﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_2
{
    internal class l7
    {
        class NumberManipulator
        {
            public void Swap(ref int x, ref int y)
            {
                int temp;
                temp = x;   // save the value of x
                x = y;      // put y into x
                y = temp;   // put temp into y
            }
        }
        class TestRef
        {
            static void Main(string[] args)
            {
                Console.WriteLine("VIRAJ - 21SOECE11011");
                NumberManipulator n = new NumberManipulator();
                int a = 100;
                int b = 200;
                Console.WriteLine("Before swap, value of a: {0}", a);
                Console.WriteLine("Before swap, value of b: {0}", b);
                n.Swap(ref a, ref b);
                Console.WriteLine("After swap, value of a: {0}", a);
                Console.WriteLine("After swap, value of b: {0}", b);
                Console.ReadLine();
            }
        }
    }
}
