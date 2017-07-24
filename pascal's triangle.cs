using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
           int i, j, k, c=1;
    Console.WriteLine("Pascal's Triangle");
    Console.Write("\nEnter number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());

    for (i = 0; i <= rows; i++)
    {
        for (k = 1; k <= rows - i; k++)
        
            Console.Write(" ");
            for (j = 0; j <= i; j++)
            {
                if (i == 0 || j == 0)
                {
                    Console.Write("{0} ",c);
                }
                else
                {
                    c = c * (i-j+1)/j;
                    Console.Write("{0} ",c);
                }
            }
        Console.WriteLine();
    }
       }
    }
} 
       