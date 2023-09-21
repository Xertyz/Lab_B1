using System;
using System.Text;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to my simple calculator!");
        Task.Delay(1000).Wait();
        Console.Clear();

        Calc();
    }

    static void Calc()
    {
        double num1, num2;
        char operation, answer;

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
                result = num1 / num2;
                break;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

        Console.WriteLine("Exit program? Type Y[yes]/N[no]");
        answer = Console.ReadLine()[0];
        if (answer.ToString() == "Y")
        {
            Environment.Exit(0);
        }
        else if (answer.ToString() == "N")
        {
            Console.Clear();
            Calc();
        }
    }
}