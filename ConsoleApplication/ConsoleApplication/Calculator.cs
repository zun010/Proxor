using System;

public class Calculator
{
    public double Sum(double a, double b)
    {
        double sum;

        sum = a + b;
        return sum;
    }

    public double Multiply(double a, double b)
    {
        double multiply;
        multiply = a * b;
        
        return multiply;
    }

    public double Divide(double a, double b)
    {
        double divide = a / b;

        return divide;
    }

    public double Subtraction(double a, double b)
    {
        return a-b;
    }

    public double SquareEquation(double a, double b, double c)
    {
        double D, x1;
        D = Subtraction(Multiply(b, b), Multiply(4, Multiply(a, c)));
        x1 = Divide(Sum(-b, Math.Sqrt(D)), Multiply(2, a));
        
        return x1;
    }
}