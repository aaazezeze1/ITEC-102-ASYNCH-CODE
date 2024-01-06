// Sort 3 real numbers in descending order. Use nested if statements
using System;
class HelloWorld {
  static void Main() {
    double num1, num2, num3;

    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    
    if (num1 > num2 && num1 > num3)
    {
        if (num2 > num3)
        {
            Console.WriteLine($"The order is " + num1 + ", " + num2 + ", " + num3);
        }
        else
        {
            Console.WriteLine($"The order is " + num1 + ", " + num3 + ", " + num2);
        }
    }
    if (num2 > num1 && num2 > num3)
    {
        if (num1 > num3)
        {
            Console.WriteLine($"The order is " + num2 + ", " + num1 + ", " + num3);
        }
        else
        {
            Console.WriteLine($"The order is " + num2 + ", " + num3 + ", " + num1);
        }
    }
    if (num3 > num1 && num3 > num2)
    {
        if (num1 > num2)
        {
            Console.WriteLine($"The order is " + num3 + ", " + num1 + ", " + num2);
        }
        else
        {
            Console.WriteLine($"The order is " + num3 + ", " + num2 + ", " + num1);
        }
    }
  }
}