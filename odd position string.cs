using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    string outputString = string.Empty;
    Console.Write("Enter the word: ");
    string data = Console.ReadLine();

    for (int i = 0; i < data.Length; i++)
    {
        if ( (i%2) == 0)
        {
           outputString += data[i];
        }
    }
 
    Console.WriteLine(outputString);
       }
   
    }

} 