using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

      Console.WriteLine("Taking array element from user");
      
       int arrayElementSum = 0;
      int[] array = new int[4];
      for(int i = 0; i < array.Length; i++)
      {
      array[i]= Convert.ToInt32(Console.ReadLine());
      arrayElementSum += array[i];
      }
      Console.WriteLine("Array is: [{0}]",string.Join(", ",array));
      Console.WriteLine("Sum of array elements is {0}",arrayElementSum);
       
       }
   
    }

}   
