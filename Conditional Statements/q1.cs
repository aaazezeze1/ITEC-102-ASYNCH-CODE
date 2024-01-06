// Odd or Even Number
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    var result = num % 2 == 0 ? "The number is even" : "The number is odd";
    Console.WriteLine(result);
    }
}