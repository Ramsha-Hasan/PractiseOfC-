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
       for (int i = 0; i <= 9 ; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            sum = sum + n;
            Console.WriteLine("sum is {0}",sum);
            
        }
       Console.WriteLine("Sum of numbers are {0}",sum);    
       }

    }
} 