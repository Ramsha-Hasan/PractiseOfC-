using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
         Console.Write("Enter number of rows: ");
         int rows = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine(" ");
         int values = rows + 1;

          Console.WriteLine("Triangle 1");
       for (int i = 1; i <= values; i++)
         {
             for (int j = 1; j <= i; j++)
             {
                 
                 Console.Write(" *");
             }
             Console.WriteLine("");
         }

        Console.WriteLine("");

       Console.WriteLine("Triangle 2");
         
       Console.WriteLine("");
            for (int i = 1; i <= values; i++)
         {
             for (int j = 1; j <= values - i; j++)
             {
                 
                 Console.Write(" *");
             }
             Console.WriteLine("");
         }
         
         

       
       }
    }
} 
       