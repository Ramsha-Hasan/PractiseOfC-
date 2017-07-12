using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        Console.WriteLine("Checking nearest number");
        Console.Write("Enter the value of number from which the other numbers will be compared: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Value 1 is: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Value 2 is: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int answer1 = number - a ;
        int answer2 = number - b ;
      
        if (a>number || b>number)
        {
            Console.WriteLine("Values should be less than {0}",number);
        }
       
        else if (answer1 > answer2)
        {
            Console.WriteLine("{0} is nearer to {1}.",b,number);
        }
        else 
        {
             Console.WriteLine("{0} is nearer to {1}",a,number);
        }
      

       }
   
    }

}   
