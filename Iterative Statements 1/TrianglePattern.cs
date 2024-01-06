/* C# program that takes user input for the number of rows and then prints the specified pattern below:
*
**
***
****
*****
****
***
**
*
*/

using System;
class HelloWorld {
  static void Main() {
    // half diamond or pyramid 
    int a, b, c = 5, d, e = 0;

    // first loop inside the nested is yung spaces for formatting the pyramid
    // second loop inside the nested is yung asterisk design
    for (a = 0; a <= 5; a++)
    {
        for (b = 0; b <= c; b++)
        {
            Console.Write(" ");
        }
        c--;
        for (d = 0; d <= e; d++)
        {
            Console.Write("*");
        }
        e += 2;
        Console.WriteLine();
    }
  }
}