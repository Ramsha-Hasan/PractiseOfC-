using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
       
       Console.Write("Enter the number of terms ");
       int n = Convert.ToInt32(Console.ReadLine());

       for (int i = 1; i <= n; i++)
       {
           int cube = i * i * i;
           Console.WriteLine("Cube of {0} is {1}",i,cube);
       }  
       }

    }
} 
       