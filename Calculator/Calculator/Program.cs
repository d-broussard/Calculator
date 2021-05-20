using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C#");
            var num1 = 0;
            var num2 = 0;

            Console.WriteLine("Enter your first number, and then press enter.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter your second number, and then press enter.");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - divide");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

        }
    }
}
