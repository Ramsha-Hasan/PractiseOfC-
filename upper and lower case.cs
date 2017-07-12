using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    Console.Write("Enter the word: ");
     var data = Console.ReadLine();
     if (data.Length < 4)
     {
         string upper = data.ToUpper();
         Console.WriteLine("answer is: {0}",upper);
     }
     else if (data.Length >= 4)
     {
         string firstFourCharacter = data.Substring(0).ToLower();
         Console.WriteLine("answer is: {0}",firstFourCharacter);
     }
      

       }
   
    }

} 