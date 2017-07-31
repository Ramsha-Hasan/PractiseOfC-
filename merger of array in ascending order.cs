using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

           Console.Write("Merging of two arrays in ascending order");
           int size1,size2,i,size3,j,value;
           
           Console.Write("\n\n");


           //array 1
           Console.Write("\nEnter size of array 1: ");
           size1 = Convert.ToInt32(Console.ReadLine());
           int[] array1 = new int [size1];
           for (i = 0; i < size1; i++)
           {
               Console.Write("Element {0}: ",i);
               array1[i] = Convert.ToInt32(Console.ReadLine());
           }
           Console.Write("Array1 is ");
           for (i = 0; i < size1; i++)
           {
               Console.Write("{0} ",array1[i]);
           }
           
           Console.Write("\n\n");

           //array2
           Console.Write("\nEnter size of array 2: ");
           size2 = Convert.ToInt32(Console.ReadLine());
           int[] array2 = new int [size2];
           for (i = 0; i < size2; i++)
           {
               Console.Write("Element {0}: ",i);
               array2[i] = Convert.ToInt32(Console.ReadLine());
           }
            Console.Write("Array2 is ");
             for (i = 0; i < size2; i++)
           {
               Console.Write("{0} ",array2[i]);
           }
            
            Console.Write("\n\n");

            //merging both arrays as array3

        size3 = size1 + size2;
        int[] array3 = new int [size3];
        for (i = 0; i < size1; i++)
        {
            array3[i] = array1[i];
        }
        for (j = 0; j < size2; j++)
        {
            array3[i] = array2[j];
            i++;
        }
         Console.Write("Array3 is ");
             for (i = 0; i < size3; i++)
           {
               Console.Write("{0} ",array3[i]);
           }

           Console.Write("\n\n");

           // array3 in ascending order

    for(i=0; i<size3; i++)
    {
     for(j=i+1; j<size3; j++)
      {
       if(array3[j] < array3[i])
        {
         value = array3[i];
         array3[i] = array3[j];
         array3[j] = value;
       }
      }
    }
    Console.Write("\nArray3 in ascending order: ");
    for(i=0; i < size3; i++)
    {
        Console.Write("{0} ",array3[i]);
    }
    
    Console.Write("\n\n");
       }
    }
} 
       