using System;
class HelloWorld {
  static void Main() {
    try
    {
        Console.WriteLine("Welcome to the Loan Calculator!\n");
        Console.Write("Please Enter the Loan Amount: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please Enter the Annual Interest Rate (e.g., 5.5 for 5.5%): ");
        double annualInterest = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please Enter the Loan Duration in Years: ");
        int loanDuration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
    
        double monthlyInterest = (annualInterest / 12) / 100;
        int monthlyPay = loanDuration * 12;
    
        // main formula for computing the PMT
        double constPow = Math.Pow((1 + monthlyInterest), monthlyPay);
        double PMT = Convert.ToSingle((loanAmount * monthlyInterest * constPow) / (constPow - 1));
    
        // removes the other digits after 2 digits and doesn't round off
        // example: 0.012345678 turns into 0.12
        decimal pmtDecim = (decimal)PMT;
        decimal result = decimal.Truncate(pmtDecim * 100m) / 100m;
    
        Console.WriteLine("Calculating...\n");
        Console.WriteLine("Your Monthly Loan Payment is: $" + result);
    } 
    catch
    {
        Console.WriteLine("Error! Try Again");
    }
  }
}