using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
        string orignalString;
        string reverseString = "";
        Console.Write("Orignal String Is: ");
        orignalString = Console.ReadLine();
        int length = orignalString.Length - 1;
        while (length >= 0)
        {
            reverseString += orignalString[length];
            length--;
        }
        Console.WriteLine("Reverse String Is {0}",reverseString);
        }
    }
} 