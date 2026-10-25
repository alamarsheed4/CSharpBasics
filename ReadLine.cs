using System;

namespace MyCSharpApp
{

class ConsoleReadLine
{
    static void Main(){

        Console.WriteLine("Please Enter Your Name");

        string name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Please Enter Your Password");
        string password = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Please Enter Employee Id");
        string emp = Console.ReadLine() ?? string.Empty;

        // Console.WriteLine($"Your Name is {name}");
        // Console.WriteLine($"Your Password is {password}");
        // Console.WriteLine($"Your Employee Id is {emp}");

       string message = string.Format($"Your Name is {name} & password is {password} & employee id id {emp}");
    
        Console.WriteLine(message);
    }
}
}