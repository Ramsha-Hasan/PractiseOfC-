using System;
namespace c
{
    class Program
    {

      static string DecToHex(decimal deci)
      {
        string result = String.Empty;
        decimal decNum = deci;

        while (decNum >= 1)
        {
            var remainder = decNum % 16;
        //  Console.WriteLine("Remainder is: {0}",remainder);
            var quotient = decNum = decNum / 16;
       //   Console.WriteLine("Quotient is: {0}",quotient);
            //Converting the remainder to hexvalue
            result = ((int)remainder).ToString("X") +result;
        }
           return result;
      }
      static void Main(string[] args)
        {
        Console.WriteLine("Converting decimal to Hexadecimal");
        Console.Write("Enter a decimal value ");
        decimal decNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Decimal Value {0} is equal to {1} in Hexadecimal",decNum,DecToHex(decNum));
        
        Console.WriteLine("");
        Console.WriteLine("Converting Hexadecimal to decimal");
        Console.Write("Enter a Hexadecimal value ");
        string HexNum = Console.ReadLine();
        int decAns = int.Parse(HexNum, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Hexadecimal Value {0} is equal to {1} in Decimal",HexNum,decAns);
        
        
        
        }
    }
}   
