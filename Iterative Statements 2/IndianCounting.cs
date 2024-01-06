using System;
class HelloWorld {
  static void Main() {
    // do while loop - little indians
    int num = 0;
    
    do {
        num++;
        Console.Write($"{num} little ");
        num++;
        Console.Write($"{num} little ");
        num++;
        Console.Write($"{num} little indian \n");
        
    } while (num < 9);
    num++;
    Console.WriteLine($"{num} little indian boys");
  }
}