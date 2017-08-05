using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
int size,i,j,value;
Console.Write("\nTo print the elements in descending order");

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

for (i = 0; i < size; i++)
{
    for (j = 1+i; j < size; j++)
    {
        if (array[i] < array[j])
        {
            value = array[j];
            array[j] = array[i];
            array[i] = value;
        }
    }
}

  Console.WriteLine("\nArray in descending order is [{0}].",string.Join(", ",array));
       }
    }
} 