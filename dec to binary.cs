using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
        Console.Write("Enter the numbers ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        int divisor = 2;
        string result = string.Empty;
        while ( dividend >= 1)
        {
        int Remainder = dividend%divisor;
        int Quotient = dividend = dividend/divisor;
        
        // Console.WriteLine("Quotient is: {0} ",Quotient);
        // Console.WriteLine("Remainder is: {0} ",Remainder);
        result = Remainder.ToString() + result;
        }
        Console.WriteLine("Binary: {0}",result);
        
        }

    }
} 
       