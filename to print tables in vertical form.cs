using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
              
   Console.Write("Enter number: ");
   int n= Convert.ToInt32(Console.ReadLine());   
   Console.Write("Multiplication table from 1 to {0}.",n);
   for(int i=1;i<=12;i++)
   {
     for(int j=1;j<=n;j++)
     {
           int product = j*i;
           Console.Write("{0}x{1} = {2} \t\t",j,i,product);
      }
     Console.Write("\n");
    }
       }
    }
} 
       