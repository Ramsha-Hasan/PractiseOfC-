using System;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
    
   int[] array1 = {1, 2, 3};
   int[] array2 = {4, 5, 6};
   int[] array3 = {7, 8, 9};

   Console.WriteLine("Array 1 is: [{0}]",string.Join(", ",array1));
   Console.WriteLine("Array 2 is: [{0}]",string.Join(", ",array2));
   Console.WriteLine("Array 3 is: [{0}]",string.Join(", ",array3));

   int[] newArray = {array1[1], array2[1], array3[1]};
   Console.WriteLine("The array obtained from the middle elements of above 3 arrays will be [{0}]",string.Join(", ",newArray));
         
      }
   
    }

}   
