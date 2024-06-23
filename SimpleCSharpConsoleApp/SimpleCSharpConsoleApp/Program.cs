using System;

class Calculator
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);

            Console.WriteLine("\n\nSelect an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("\n\nResult: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("\n\nResult: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("\n\nResult: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("\n\nResult: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation selected.");
                    break;
            }

            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                keepRunning = false;
            }
        }

        Console.WriteLine("byeee!");
    }
}