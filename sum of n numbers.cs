using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
       
       Console.WriteLine("Enter the number of numbers");
       int n = Convert.ToInt32(Console.ReadLine());
       int sum = 0;
       for (int i = 0; i <= n ; i++)
        {
            Console.WriteLine(i); 
            sum = sum + i;
        }
       Console.WriteLine("Sum of {0} number is {1}",n,sum);
     
        
       }

    }
} 