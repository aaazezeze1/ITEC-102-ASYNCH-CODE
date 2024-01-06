using System;
class HelloWorld {
  static void Main() {
    // Question 3: Create a third C# project that calculates the sum and average of three input numbers and displays the results.
    Console.Write("Enter First Number: ");
    double num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Second Number: ");
    double num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Third Number: ");
    double num3 = Convert.ToInt32(Console.ReadLine());
    
    double sum = num1 + num2 + num3;
    double ave = sum / 3;
    
    Console.WriteLine("The sum of all numbers is: " + sum);
    Console.WriteLine("The average of all numbers is: " + ave);
    
    Console.ReadKey();
  }
}