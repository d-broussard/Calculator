using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers nums = new Numbers();
            Console.WriteLine("Console Calculator in C#");
            
            Console.WriteLine("Enter your first number, and then press enter.");
            nums.Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter your second number, and then press enter.");
            nums.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - divide");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your Result: {nums.Num1} + {nums.Num2} = " + (nums.Num1 + nums.Num2));
                    break;
                case "s":
                    Console.WriteLine($"Your Result: {nums.Num1} + {nums.Num2} = " + (nums.Num1 - nums.Num2));
                    break;
                case "m":
                    Console.WriteLine($"Your Result: {nums.Num1} * {nums.Num2} = " + (nums.Num1 * nums.Num2));
                    break;
                case "d":
                    Console.WriteLine($"Your Result: {nums.Num1} / {nums.Num2} = " + (nums.Num1 / nums.Num2));
                    break;
            }
            Console.WriteLine("Have a nice day =)");
        }
    }
}
