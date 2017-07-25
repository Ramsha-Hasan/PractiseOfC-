using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

    int remainder, strongNumber, i, sum = 0, factorial = 1;
    
   
    Console.Write("Strong Number");

   Console.Write("\nEnter the number ");
   int number = Convert.ToInt32(Console.ReadLine());
   
   strongNumber = number;
   

   while (number != 0)
  {
       factorial = 1;
       remainder = number % 10;
       //Console.Write("\nremainder is {0}",remainder);
       for (i = 1; i <= remainder; i++)
       {
           factorial = factorial * i;
       }
       //Console.Write("\nFactorial of {0} is {1}",remainder,factorial);
       sum = sum + factorial;
       //Console.Write("\nsum is {0}",sum);
       number = number / 10;
       //Console.Write("\nnow number is {0}",number);
   }

if (sum == strongNumber)
{
    Console.Write("\nIts a strong number");
}
else
{
    Console.Write("\nIts not a strong number");
}
       }
    }
} 
       