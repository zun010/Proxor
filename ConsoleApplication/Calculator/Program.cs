using System;
using System.Text;

namespace Proxor.Calculator
{
    public class Program
    {
        public static void Main()
        {
            RunCalculator();
        }

        private static void RunCalculator()
        {
            var calculatorHistory = new CalculatorHistory();
            var calculator = new Calculator(calculatorHistory);
            
            while (true)
            {
                Console.WriteLine("Введите операцию");
                string operation = Console.ReadLine();

                if (operation == "history")
                {
                    var allHistory = calculatorHistory.GetAllHistory();
                    Console.WriteLine(allHistory);
                    continue;
                }

                if (operation == "clear")
                {
                    calculatorHistory.Clear();
                    continue;
                }

                double number;
                string input;
                do
                {
                    Console.WriteLine("Введите первое число");
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out number));
                
                string secondInput;
                double secondNumber;
                do
                {
                    Console.WriteLine("Введите второе число");
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
                    Console.WriteLine($"Результат: {result}\n");
                else
                    Console.WriteLine("Такой операции не существует"); 
                
            }
        }
    }
}