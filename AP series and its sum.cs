using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
   Console.Write("AP series");

   int sum = 0;

   Console.Write("\nEnter the starting number ");
   int startNumber = Convert.ToInt32(Console.ReadLine());

   Console.Write("\nEnter the terms ");
   int terms = Convert.ToInt32(Console.ReadLine());

   Console.Write("\nEnter the difference ");
   int difference = Convert.ToInt32(Console.ReadLine());

Console.Write("\n{0} + ",startNumber);

   for (int i = 1; i <= terms - 1; i++)
   {
       sum += startNumber;
       startNumber = startNumber + difference;
       Console.Write("{0} + ",startNumber);
   }
    
   sum +=startNumber;
   Console.Write("\n\nsum of AP series is {0}",sum);
       }
    }
} 
       