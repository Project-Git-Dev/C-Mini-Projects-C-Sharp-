using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid number, Please pick a number");
                return;
            }

            Console.Write("Enter an operator (+ - * /): ");
            if (!char.TryParse(Console.ReadLine(), out char op))
            {
                Console.WriteLine("Invalid operator input");
                return;
            }

            if (op != '+' && op != '-' && op != '*' && op != '/')
            {
                Console.WriteLine("Please enter a valid operator (+ - * /)");
                return;
            }

            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid number, Please pick a number");
                return;
            }

            switch (op)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("You cannot divide by zero!");
                    else
                        Console.WriteLine((double)a / b);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.ReadLine();
        }
    }
}
