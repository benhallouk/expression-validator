using System;

namespace ExpressionValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any expression to be validated");
            var expression = Console.ReadLine();
            if (Validator.ValidateExpression(expression))
            {
                Console.WriteLine("Your expression is valid");
            }
            else
            {
                Console.WriteLine("Your expression is invalid");
            }
        }
    }
}
