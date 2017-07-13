using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        Console.WriteLine("Enter the numbers");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        bool checker = (number1 % 2 != 0 || number2 % 2 != 0 ) ? true : false;
        
        Console.WriteLine(checker ? "Odd number is present" : "Both are even" );    
        }

    }
} 