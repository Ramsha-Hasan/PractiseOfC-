using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
   Console.Write("Enter the number of rows: ");
   int rows = Convert.ToInt32(Console.ReadLine());

   int count = rows - 1;
   int i, j;

   for (i = 1; i <= rows; i++)
   {
       for (j = 1; j <= count; j++)
       
           Console.Write(" ");
           count--;
        for (j = 1; j <= 2 * i - 1; j++)
         
            Console.Write("*");
            Console.WriteLine();
   }

   count = 1;
   for (i = 1; i <= rows - 1; i++)
   {
       for (j = 1; j <= count; j++)
       
           Console.Write(" ");
           count++;
           for (j = 1; j <= 2 * (rows - i) - 1; j++)
           
               Console.Write("*");
               Console.WriteLine();
           
       
   }
       }
    }
} 
       