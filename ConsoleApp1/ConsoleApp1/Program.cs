using System;
using System.Text;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Simple Console Calculator");
        Console.WriteLine("Available operations: +, -, *, /");

        Console.Write("Input first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input operand: ");
        operation = Console.ReadLine()[0];

        Console.Write("Input second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: divide by zero");
                    return;
                }
                break;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}