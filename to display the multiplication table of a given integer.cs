using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
       
       Console.Write("Enter the number ");
       int n = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("");
       Console.WriteLine("Multiplication of {0}",n);

       for (int i = 1; i <= 12; i++)
       {
           int product = i * n;
           Console.WriteLine("{0} * {1} = {2}",n,i,product);
       } 
       }

    }
} 
       