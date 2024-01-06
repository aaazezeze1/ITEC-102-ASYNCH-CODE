using System;
class HelloWorld {
  static void Main() {
    // Question 1: Create a C# project that accepts the first name, middle name, and last name from the user, then prints the full name.
    Console.Write("Enter First Name: ");
    string firstName = Console.ReadLine();
    Console.Write("Enter Middle Name: ");
    string middleName = Console.ReadLine();
    Console.Write("Enter Last Name: ");
    string lastName = Console.ReadLine();
    
    Console.WriteLine("Your name is " + firstName + " " + middleName + " " + lastName);
    Console.ReadKey();
  }
}