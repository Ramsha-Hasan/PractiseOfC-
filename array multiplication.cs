using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
         int[] array1 = {1, 2, 3, 4, 5};
         int[] array2 = {6, 7, 8, 9, 10};

         Console.WriteLine("Performing multiplication of corresponding elements");

          for (int i = 0; i < 5; i++)
         {
             Console.WriteLine("answer of element {0} is: {1} ",i, array1[i]*array2[i]) ;
         }
        
      }
   
    }

}   
