using System;

class Program
{
    static void Main()
    {
        // Exercise 1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("The first number is greater than the second.");
        }
        else
        {
            Console.WriteLine("The first number is less than the second.");
        }

        Console.WriteLine();

        // Exercise 2
        Console.WriteLine("Exercise 2:");
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 5 && number < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine();

        // Exercise 3
        Console.WriteLine("Exercise 3:");
        Console.Write("Enter a number: ");
        double checkNumber = Convert.ToDouble(Console.ReadLine());

        if (checkNumber == 5 || checkNumber == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine();

        // Exercise 4
        Console.WriteLine("Exercise 4:");
        Console.Write("Enter deposit amount: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        double finalDepositAmount;

        if (depositAmount < 100)
        {
            finalDepositAmount = depositAmount * 1.05;
        }
        else if (depositAmount <= 200)
        {
            finalDepositAmount = depositAmount * 1.07;
        }
        else
        {
            finalDepositAmount = depositAmount * 1.10;
        }

        Console.WriteLine("Amount with interest: " + finalDepositAmount);

        Console.WriteLine();

        // Exercise 5
        Console.WriteLine("Exercise 5:");
        Console.Write("Enter deposit amount: ");
        double depositAmountWithBonus = Convert.ToDouble(Console.ReadLine());
        double finalAmountWithBonus;

        if (depositAmountWithBonus < 100)
        {
            finalAmountWithBonus = depositAmountWithBonus * 1.05 + 15;
        }
        else if (depositAmountWithBonus <= 200)
        {
            finalAmountWithBonus = depositAmountWithBonus * 1.07 + 15;
        }
        else
        {
            finalAmountWithBonus = depositAmountWithBonus * 1.10 + 15;
        }

        Console.WriteLine("Amount with interest and bonus: " + finalAmountWithBonus);

        Console.WriteLine();

        // Exercise 6
        Console.WriteLine("Exercise 6:");
        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        int operationNumber = Convert.ToInt32(Console.ReadLine());

        switch (operationNumber)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }

        Console.WriteLine();

        // Exercise 7
        Console.WriteLine("Exercise 7:");
        Console.WriteLine("Enter operation number:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        int selectedOperation = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        switch (selectedOperation)
        {
            case 1:
                Console.WriteLine("Result: " + (number1 + number2));
                break;
            case 2:
                Console.WriteLine("Result: " + (number1 - number2));
                break;
            case 3:
                Console.WriteLine("Result: " + (number1 * number2));
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
    }
}