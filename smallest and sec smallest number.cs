using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
int size,i;
int smallestValue = 100;
int secondSmallestValue = 0;
Console.Write("\n\nEnter the size of array ");
size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Console.Write("\nInput elements:\n\n");
for (i = 0; i < size; i++)
{
    Console.Write("Element {0}: ",i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nArray is [{0}].",string.Join(", ",array));

    for(i = 0; i < size; i++)
    {
        if(smallestValue > array[i])
        {
            secondSmallestValue = smallestValue;
            smallestValue = array[i];
        }
    }

  Console.WriteLine("\nSmallest number is {0}.",smallestValue);
  Console.WriteLine("\nSecond smallest number is {0}.",secondSmallestValue);
       }
    }
} 