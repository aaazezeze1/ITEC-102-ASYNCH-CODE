using System;
class HelloWorld {
  static void Main() {

    int i, j, k = 4;

    for (i = 0; i <= 3; i++)
    {
        for (j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
        for (k = i - 1; j >= 1; j--)
        {
            Console.Write(j);
        }
        Console.WriteLine(" ");
    }
}
}