using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                double number;
                string input;
                do
                {
                    Console.WriteLine("Введите число");
                     input = Console.ReadLine();

                } while (!double.TryParse(input, out number));

                Console.WriteLine("Введите операцию");
                string operation = Console.ReadLine();
                
                string secondInput;
                double secondNumber;
                do
                {
                    Console.WriteLine("Введите число");
                    secondInput = Console.ReadLine();
                } while (!double.TryParse(secondInput, out secondNumber));

                double result = operation switch
                {
                    "sum" => calculator.Sum(number, secondNumber),
                    "mul" => calculator.Multiply(number, secondNumber),
                    "div" => calculator.Divide(number, secondNumber),
                    "sub" => calculator.Subtraction(number, secondNumber),
                    _ => double.NaN
                };

                if (!double.IsNaN(result))
                    Console.WriteLine(result);
                else
                    Console.WriteLine("Такой операции не существует");
            }
        }
    }
}