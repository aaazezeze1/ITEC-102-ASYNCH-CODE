using System;
class HelloWorld {
  static void Main() {
    // for loop login 
    string username; string password; int login_attempts = 0;
    
    // asks the same question 3 times then shows error if invalid input
    for (int i = 0; i < 3;  i++) {
        Console.Write("Enter Username: ");
        username = Console.ReadLine();
        Console.Write("Enter Password: ");
        password = Console.ReadLine();
        
        if (username != "Johnny" || password != "2023") {
            login_attempts++;
        } else
        break;
    }
    
    if (login_attempts > 2) {
        Console.WriteLine("Login Failed. Try Again");
    } else {
        Console.WriteLine("Login Success!");
    }
  }
}