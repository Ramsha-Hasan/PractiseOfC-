using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

    int remainder, number, reverseNumber = 0;
   
    Console.Write("Palindrome Number");

   Console.Write("\nEnter the number ");
   int orignalNumber = Convert.ToInt32(Console.ReadLine());
   
   number = orignalNumber;

   while (orignalNumber != 0)
   {
       remainder = orignalNumber % 10;
       reverseNumber = reverseNumber * 10 + remainder;
       orignalNumber = orignalNumber / 10;
   }

  
   if (number == reverseNumber)
   {
        Console.Write("Its a palindrome number");
   }
   else
   {
       Console.Write("Not a palindrome number");
   }
       }
    }
} 
       