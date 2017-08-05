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
int largestValue = 0;
int secondLargestValue = 0;
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
        if(largestValue < array[i])
        {
            secondLargestValue = largestValue;
            largestValue = array[i];
        }
    }

  Console.WriteLine("\nLargest number is {0}.",largestValue);
  Console.WriteLine("\nSecond Largest number is {0}.",secondLargestValue);
       }
    }
} 