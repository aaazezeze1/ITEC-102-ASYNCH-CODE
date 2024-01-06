using System;
class HelloWorld {
  static void Main() {
    // Question 2: Create another C# project that reads the user's age from the console and prints the age after 10 years.
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    age = age + 10;
    Console.WriteLine("Your age after 10 years is {0}", age);
    Console.ReadKey();
  }
}