using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

int[] givenArray = new int[5];

Console.WriteLine("Enter the elements: ");

for (int i = 0; i < givenArray.Length; i++)
{
    givenArray[i]=Convert.ToInt32(Console.ReadLine());   
}
Console.WriteLine("Given array is [{0}].",string.Join(", ",givenArray));

Console.WriteLine("");

int variable = givenArray[0]; 
for (int i = 0; i < givenArray.Length-1; i++)
{
    givenArray[i] =  givenArray[i + 1];
}

givenArray[givenArray.Length-1] = variable;
Console.Write("After rotating array is [{0}].",string.Join(", ",givenArray));

Console.WriteLine("");
        }
   
    }

} 