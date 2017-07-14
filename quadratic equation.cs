using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
         Console.WriteLine("Quadratic Equations");
         Console.WriteLine("Enter the numbers");
         int a = Convert.ToInt32(Console.ReadLine());
         int b = Convert.ToInt32(Console.ReadLine());
         int c = Convert.ToInt32(Console.ReadLine());
         int underroot = (b*b - 4*a*c);
         int root1 = (((-b) + underroot)/2*a);
         int root2 = (((-b) - underroot)/2*a);

         //Console.WriteLine(underroot);
         if (a == 0)
         {
             Console.WriteLine("'a' can never be zero");
         }
         else if (underroot < 0)
         {
             Console.WriteLine("imaginary roots");
         }
         else
         {
            Console.WriteLine("Root 1 is: {0} and Root 2 is {1}",root1,root2);
         }

        
       }

    }
} 
       