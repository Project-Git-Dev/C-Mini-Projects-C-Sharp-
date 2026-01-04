using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Invalid number");
                return;
            }

            Console.Write("Enter a operator(+ - / *): ");
            char op = Console.ReadKey().KeyChar;

            Console.Write("Enter another number: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid number");
                return;
            }




            switch (op)
            {
                case '+': Console.WriteLine(a + b); break;
                case '-': Console.WriteLine(a - b); break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("You cannot divide by zero! ");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                case '*': Console.WriteLine(a * b); break;
            
            }
            Console.ReadLine();
        }
    }
}

