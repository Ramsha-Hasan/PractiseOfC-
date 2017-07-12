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
      
      int[] array = new int[10];
      for(int i = 0; i < array.Length; i++)
      {
      array[i]= Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("Array is: [{0}]",string.Join(", ",array));
    
           
      Console.WriteLine("Enter the number to be counted in the above array: ");  
      int number = Convert.ToInt32(Console.ReadLine());
       

      int a = array.Count(n => n == number);
      Console.Write("Number of {0} present in the above array is {1}",number,a);
       
       }
   
    }

}  