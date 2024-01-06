// Conditional Statements Question Number 5 Shorter Answer
using System;
class HelloWorld {
    static void Main() {
        Console.Write("Enter a number between 0 to 999: ");
        int num = Convert.ToInt32(Console.ReadLine());
    
        int ones = num % 10;
        int tens = num % 100;
        int hundreds = num / 100;
       
        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
    
        switch (hundreds)
        {
            case 1: Console.Write("One Hundred "); break;
            case 2: Console.Write("Two Hundred "); break;
            case 3: Console.Write("Three Hundred "); break;
            case 4: Console.Write("Four Hundred "); break;
            case 5: Console.Write("Five Hundred "); break;
            case 6: Console.Write("Six Hundred "); break;
            case 7: Console.Write("Seven Hundred "); break;
            case 8: Console.Write("Eight Hundred "); break;
            case 9: Console.Write("Nine Hundred "); break;
        }
    
        if (tens < 20 && tens > 10)
        {
            switch (tens)
            {
                case 11: Console.Write("Eleven "); break;
                case 12: Console.Write("Twelve "); break;
                case 13: Console.Write("Thirteen "); break;
                case 14: Console.Write("Fourteen "); break;
                case 15: Console.Write("Fiveteen "); break;
                case 16: Console.Write("Sixteen "); break;
                case 17: Console.Write("Seventeen "); break;
                case 18: Console.Write("Eighteen "); break;
                case 19: Console.Write("Nineteen "); break;
            }
        }
        else
        {
            switch (tens - ones)
            {
                case 20: Console.Write("Twenty "); break;
                case 30: Console.Write("Thirty "); break;
                case 40: Console.Write("Forty "); break;
                case 50: Console.Write("Fifty "); break;
                case 60: Console.Write("Sixty "); break;
                case 70: Console.Write("Seventy "); break;
                case 80: Console.Write("Eighty "); break;
                case 90: Console.Write("Ninety "); break;
            }
    
            switch (ones)
            {
                case 1: Console.Write("One "); break;
                case 2: Console.Write("Two "); break;
                case 3: Console.Write("Three "); break;
                case 4: Console.Write("Four "); break;
                case 5: Console.Write("Five "); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven "); break;
                case 8: Console.Write("Eight "); break;
                case 9: Console.Write("Nine "); break;
                case 10: Console.Write("Ten "); break;
            }
        }
    }
}