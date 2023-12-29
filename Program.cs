
using System;

class NewtonMethod
{
    public static double FindRoot(Func<double, double> function, Func<double, double> derivative, double initialGuess, double tolerance)
    {
        double x0 = initialGuess;
        double x1 = x0 - function(x0) / derivative(x0);
        
        while (Math.Abs(x1 - x0) > tolerance)
        {
            x0 = x1;
            x1 = x0 - function(x0) / derivative(x0);
        }
        
        return x1;
    }
}

class Program
{
    static void Main()
    {
        // Пример использования метода Ньютона для нахождения нуля функции f(x) = x^2 - 4
        Func<double, double> function = x => x * x - 4;
        Func<double, double> derivative = x => 2 * x;
        double initialGuess = 2.5;
        double tolerance = 0.0001;

        double root = NewtonMethod.FindRoot(function, derivative, initialGuess, tolerance);
        Console.WriteLine("Root of the function: " + root);
    }
}
