using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

    int sum = 0;
    

    Console.WriteLine("Sum of series");

    Console.Write("Value is: ");
    int Value = Convert.ToInt32(Console.ReadLine());

    Console.Write("Number of terms: ");
    int terms = Convert.ToInt32(Console.ReadLine());

    int ValueToBeAdded = Value;
    

    for (int i = 1; i <= terms; i++)
    {
             sum += Value;
	         Console.Write("{0} + ",Value);
	         Value=Value*10+ValueToBeAdded;
    }
   Console.WriteLine("\nThere sum is {0}.",sum);
    Console.WriteLine(" ");
      
       
       }
    }
} 
       