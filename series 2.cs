using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
      
        Console.Write("\nNumber of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nValue is: ");
        int Value = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nValue to be added: ");
        int ValueToBeAdded = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");        

        int sum = 0;

        for (int i = 1; i <= terms; i++)
        {
             sum += Value;
	         Console.Write("{0}   ",Value);
	         Value=Value*10+ValueToBeAdded;
        }


         Console.Write("\nSum is: {0}",sum);

      
      
       
       }
    }
} 
       