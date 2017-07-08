using System;

namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Enter Number");
          int number = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(" ");
          for (int i = 0; i < 2; i++)
          {
              Console.WriteLine("{0} {0} {0} {0}", number);
          }
         Console.WriteLine(" ");     
        
         for (int i = 0; i < 2; i++)
         {
              Console.WriteLine("{0}{0}{0}{0}", number);
        }


        }
    }
    
}
      
      
      