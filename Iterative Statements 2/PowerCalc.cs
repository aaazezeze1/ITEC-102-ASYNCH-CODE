using System;
class HelloWorld {
  static void Main() {
    // while loop - input base and exponent and display the power of the number 
    double num1, num2, result; char again;
    
    Console.Write("Enter base: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter exponent: ");
    num2 = Convert.ToDouble(Console.ReadLine());
        
    result = Math.Pow(num1, num2);
    Console.WriteLine(result);
    
    Console.Write("Would you like to continue? (type 'y' or 'Y'): ");
    again = Convert.ToChar(Console.ReadLine());
    
    while (again == 'y' || again == 'Y')
    {
        Console.Write("Enter base: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter exponent: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    
        result = Math.Pow(num1, num2);
        Console.WriteLine(result);
    
        Console.Write("Would you like to continue? (type 'y' or 'Y'): ");
        again = Convert.ToChar(Console.ReadLine());
    }
    
    Console.WriteLine("Invalid Input");
  }
}