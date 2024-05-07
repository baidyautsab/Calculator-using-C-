using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcultor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Initialize expression string
                string expression = "";

                // Ask for two numbers from the user
                Console.WriteLine("Enter first number:");
                double num1 = GetNumberFromUser();
                expression += num1.ToString();

                Console.WriteLine("Enter second number:");
                double num2 = GetNumberFromUser();
                expression += " " + num2.ToString();

                // Display options to the user
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.WriteLine("6. Exponentiation (^)");
                Console.WriteLine("7. Sine (sin)");
                Console.WriteLine("8. Cosine (cos)");
                Console.WriteLine("9. Tangent (tan)");
                Console.WriteLine("10. Square Root (√)");
                Console.WriteLine("11. Exit");

                // Get user's choice
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Perform the operation based on user's choice
                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        expression += " + ";
                        break;
                    case 2:
                        result = num1 - num2;
                        expression += " - ";
                        break;
                    case 3:
                        result = num1 * num2;
                        expression += " * ";
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            expression += " / ";
                        }
                        else
                        {
                            Console.WriteLine("Error! Division by zero.");
                        }
                        break;
                    case 5:
                        if (num2 != 0)
                        {
                            result = num1 % num2;
                            expression += " % ";
                        }
                        else
                        {
                            Console.WriteLine("Error! Division by zero.");
                        }
                        break;
                    case 6:
                        result = Math.Pow(num1, num2);
                        expression += " ^ ";
                        break;
                    case 7:
                        result = Math.Sin(num1);
                        expression = "sin(" + num1.ToString() + ")";
                        break;
                    case 8:
                        result = Math.Cos(num1);
                        expression = "cos(" + num1.ToString() + ")";
                        break;
                    case 9:
                        result = Math.Tan(num1);
                        expression = "tan(" + num1.ToString() + ")";
                        break;
                    case 10:
                        result = Math.Sqrt(num1);
                        expression = "sqrt(" + num1.ToString() + ")";
                        break;
                    case 11:
                        Console.WriteLine("Exiting...");
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice! Please choose a valid option.");
                        break;
                }

                // Display the result
                if (choice >= 1 && choice <= 10)
                {
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine($"Expression: {expression} = {result}");
                }

                // Ask if the user wants to continue
                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                    break;
            }
        }

        // Function to get a valid number from the user
        static double GetNumberFromUser()
        {
            double num;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
        }
    }
}
