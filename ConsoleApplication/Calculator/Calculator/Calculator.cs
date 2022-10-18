using System;

namespace Proxor
{
    public class Calculator
    {
        private CalculatorHistory _calculatorHistory;
        
        public Calculator(CalculatorHistory calculatorHistory)
        {
            _calculatorHistory = calculatorHistory;
        }
        
        public double Sum(double a, double b)
        {
            double sum;

            sum = a + b;

            _calculatorHistory.Append($"{a} + {b}");
            return sum;
        }

        public double Multiply(double a, double b)
        {
            double multiply;
            multiply = a * b;

            _calculatorHistory.Append($"{a} * {b}");
            return multiply;
        }

        public double Divide(double a, double b)
        {
            double divide = a / b;

            _calculatorHistory.Append($"{a} / {b}");
            return divide;
        }

        public double Subtraction(double a, double b)
        {
            _calculatorHistory.Append($"{a} - {b}");
            return a - b;
        }

        public double SquareEquation(double a, double b, double c)
        {
            double D, x1;
            D = Subtraction(Multiply(b, b), Multiply(4, Multiply(a, c)));
            x1 = Divide(Sum(-b, Math.Sqrt(D)), Multiply(2, a));

            return x1;
        }
    }
}