using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

     Console.Write("Enter number 1: ");
     int number1 = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter number 2: ");
     int number2 = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter number 3: ");
     int number3 = Convert.ToInt32(Console.ReadLine());

    int greaterNumber = Math.Max(number1, Math.Max(number2,number3));
    int lowestNumber = Math.Min(number1, Math.Min(number2,number3));


    Console.WriteLine("");
    Console.WriteLine("Greater number is: {0}",greaterNumber);
    Console.WriteLine("Lowest number is: {0}",lowestNumber);


       }
   
    }

}   
