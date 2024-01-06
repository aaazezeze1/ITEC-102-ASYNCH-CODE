/* Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error message. */
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter the score: ");
    int score = Convert.ToInt32(Console.ReadLine());
    
    var result = (score >= 1 && score <= 3) ? $"The score is {score * 10}" : (score >= 4 && score <= 6) ? $"The score is {score * 100}" : (score >= 7 && score <= 9) ? $"The score is {score * 1000}" : (score == 0 || score > 9) ? "Error! Invalid Input" : "Error! Try Again";
    Console.WriteLine(result);
  }
}