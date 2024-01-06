// Biggest of three integers using nested if statements only
using System;
class HelloWorld {
  static void Main() {
    int num1, num2, num3;
    
    Console.Write("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.WriteLine("The largest number is " + num1);
        }
    }
    if (num2 > num3)
    {
        if (num2 > num1)
        {
            Console.WriteLine("The largest number is " + num2);
        }
    }
    if (num3 > num2)
    {
        if (num3 > num1)
        {
            Console.WriteLine("The largest number is " + num3);
        }
    }
  }
}