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
                // Ask for two numbers from the user
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Display options to the user
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.WriteLine("6. Exit");

                // Get user's choice
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Perform the operation based on user's choice
                double result = 0;
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error! Division by zero.");
                        break;
                    case 5:
                        if (num2 != 0)
                            result = num1 % num2;
                        else
                            Console.WriteLine("Error! Division by zero.");
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice! Please choose a valid option.");
                        break;
                }

                // Display the result
                if (choice >= 1 && choice <= 5)
                {
                    Console.WriteLine($"Result: {num1} {(char)('+' + choice - 1)} {num2} = {result}");
                }

                // Ask if the user wants to continue
                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                    break;
            }
        }
    }
}
