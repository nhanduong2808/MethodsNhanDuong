using System;

namespace MethodsNhanDuong
{
    class Program
    {
        static void Calculation(string operation, int num1, int num2)
        {
            int result = 0;
            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                // if the second number is a 0, throw an exception with message then close the program
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide a number by 0", ex.Message);
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Here is our calculation: " + num1.ToString() + " " + operation + " " + num2.ToString() + " = " + result.ToString());
        }

        static void Main(string[] args)
        {
            int num1, num2;
            string operation = "";
            Boolean status = true;

            Console.WriteLine("Hello, this is Nhan G. Duong!");

            // Asking for type of operation
            Console.Write("Please enter the type of operation you would like to do (symbol only please!): ");
            while (status)
            {
                operation = Console.ReadLine();
                if (operation == "+")
                {
                    Console.WriteLine("You have chosen: +");
                    status = false;
                }
                else if (operation == "-")
                {
                    Console.WriteLine("You have chosen: -");
                    status = false;
                }
                else if (operation == "*")
                {
                    Console.WriteLine("You have chosen: *");
                    status = false;
                }
                else if (operation == "/")
                {
                    Console.WriteLine("You have chosen: /");
                    status = false;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please choose one from the following: +, -, *, /: ");
                    status = true;
                }
            }

            // Asking for first number
            Console.Write("Now enter the first number please: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("First number should be integer only: ");
            }

            // Asking for second number
            Console.Write("Now enter the second number please: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Second number should be integer only: ");
            }

            // Calling method to do the operation
            Calculation(operation, num1, num2);
        }
    }
}
