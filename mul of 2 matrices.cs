using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {

int r,c,i,j;
Console.Write("\n\nEnter the rows of matrices ");
r = Convert.ToInt32(Console.ReadLine());

Console.Write("\n\nEnter the columns of matrices ");
c = Convert.ToInt32(Console.ReadLine());

Console.Write("\n\nMatrix 1 is: ");
int[,] matrix1 = new int[r,c];
Console.Write("\nInput elements:\n\n");

for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
    {
        Console.Write("element - [{0},{1}] : ",i,j);
		matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write("\nThe matrix 1 is: \n");
 for(i = 0; i < r; i++)
  {
      Console.Write("\n");
      for(j = 0; j < c; j++)
      {
         Console.Write("{0}\t",matrix1[i,j]);
      }
          
  }

    Console.Write("\n\n");

Console.Write("\n\nMatrix 2 is: ");
int[,] matrix2 = new int[r,c];
Console.Write("\nInput elements:\n\n");

for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
    {
        Console.Write("element - [{0},{1}] : ",i,j);
		matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write("\nThe matrix 2 is: \n");
 for(i = 0; i < r; i++)
  {
      Console.Write("\n");
      for(j = 0; j < c; j++)
      {
         Console.Write("{0}\t",matrix2[i,j]);
      }
          
  }

 Console.Write("\n");
  int[,] answer = new int[r,c];

for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
    {
        answer[i,j] = matrix1[i,j] * matrix2[i,j];
    }
}
  

Console.Write("\nThe answer is: \n");
 for(i = 0; i < r; i++)
  {
      Console.Write("\n");
      for(j = 0; j < c; j++)
      {
         Console.Write("{0}\t",answer[i,j]);
      }
          
  }
       
 Console.Write("\n");
       }
    }
} 