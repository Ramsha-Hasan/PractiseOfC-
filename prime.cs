using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("List Of Prime Numbers");
          bool isPrime = true;

          for (int i = 2; i < 50; i++)
          {
              for (int j = 2; j < 50; j++)
              {
                  if (i != j && i%j == 0)
                  {
                    isPrime = false;
                    break;  
                  }
              }
              if (isPrime)
              {
                  Console.WriteLine(i);
              }
              isPrime = true;
          }
        Console.ReadKey();
        }
    }
}