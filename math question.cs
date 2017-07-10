using System;

namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter the number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            if(number1 == number2)
            {
                int answer = 3*(number1+number2);
                 Console.WriteLine("Both numbers are equal so answer will be {0}",answer);
            }
            else
            {
                int answer = number1 + number2;
                Console.WriteLine("Both number are not equal so answer is {0}",answer);
            }
            
        }
    }
    
}
      
      
      