
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Calculator with user input 
        double num1 = 0;
        double num2 = 0;

        Console.WriteLine("First Numerical Value");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Second Numerical Value");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What operator? (+, -, /, *, ^)");
        switch (Console.ReadLine())
        {
            case "+":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" {num1} + {num2} = " + (num1 + num2));
                Console.ResetColor();
                break;
            case "-":
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" {num1} - {num2} = " + (num1 - num2));
                Console.ResetColor();
                break;
            case "/":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($" {num1} / {num2} = " + (num1 / num2));
                Console.ResetColor();
                break;
            case "*":
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($" {num1} * {num2} = " + (num1 * num2));
                Console.ResetColor();
                break;
            case "^":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"{num1}^{num2} = {(long)Math.Pow(num1, num2)}");
                Console.ResetColor();
                break;
        }


    }
}