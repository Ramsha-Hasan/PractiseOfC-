using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
       static void Main(string[] args)
       {
       Console.WriteLine("Menu driven Program");
       
       Console.WriteLine("Enter the numbers");
       int number1 = Convert.ToInt32(Console.ReadLine());
       int number2 = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("1. Addition");
       Console.WriteLine("2. Subtraction");
       Console.WriteLine("3. Multiplication");
       Console.WriteLine("4. Division");

       Console.Write("Select choice ");
       int choice = Convert.ToInt32(Console.ReadLine());

         switch (choice)
       {
           case 1:
           Console.WriteLine("You selected Addition");
           int add = number1 + number2;
           Console.WriteLine("Answer is {0}",add);
           break;

           case 2:
           Console.WriteLine("You selected Subtraction");
           int sub = number1 - number2;
           Console.WriteLine("Answer is {0}",sub);
           break;

           case 3:
           Console.WriteLine("You selected Multiplication");
           int mul = number1 * number2;
           Console.WriteLine("Answer is {0}",mul);
           break;

           case 4:
           Console.WriteLine("You selected Division");
           int div = number1 / number2;
           Console.WriteLine("Answer is {0}",div);
           break;
       }
       
     
        
       }

    }
} 
  