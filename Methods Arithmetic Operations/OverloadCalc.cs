using System;
class HelloWorld {
  static void Main() {
    // Method Overloading
    double num1, num2, num3, result; char op;
    Console.Write("Enter first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter third number: ");
    num3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter operator +,-,*,/ : ");
    op = Convert.ToChar(Console.ReadLine());

    switch (op)
    {
        case '+': Add(num1, num2); Add(num1, num2, num3); Ave(num1, num2, num3); break;
        case '-': result = num1 - num2; Console.WriteLine($"Result: {result}"); break;
        case '*': result = num1 * num2; Console.WriteLine($"Result: {result}"); break;
        case '/': result = num1 / num2; Console.WriteLine($"Result: {result}"); break;
    }
}
    static double Add(double num1, double num2)
    {
        double result = num1 + num2;
        Console.WriteLine($"Sum of the two numbers: {result}");
        return result;
    }
    static double Add(double num1, double num2, double num3)
    {
        double result = num1 + num2 + num3;
        Console.WriteLine($"Sum of the three numbers: {result}");
        return result;
    }
    static double Ave(double num1, double num2, double num3)
    {
        double result = num1 + num2 + num3;
        result = result / 3;
        Console.WriteLine($"Average of the three numbers: {result}");
        return result;
    }
}