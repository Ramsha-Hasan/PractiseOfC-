using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
         Console.Write("Enter Year: ");
         int yearValue = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Is {0} a leap year ?",yearValue);
         if (DateTime.IsLeapYear(yearValue))
         {
             Console.WriteLine("YES");
         }
         else
         {
             Console.WriteLine("NO");
         }

        
       }

    }
} 