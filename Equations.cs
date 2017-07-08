using System;

namespace c
{
    class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Enter First Number");
          int x = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter Second Number");
          int y = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter Third Number");
          int z = Convert.ToInt32(Console.ReadLine());

          int equation1 = (x+y)*z;
          Console.WriteLine("Answer of equation 1 is {0}",equation1);

          int equation2 = x*y + y*z;
           Console.WriteLine("Answer of equation 2 is {0}",equation2);
        
        }
    }
    
}
      
      
      