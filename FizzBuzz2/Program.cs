// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("FIZZBUZZ");

Console.ResetColor();

for (int i = 1; i <= 100; i++) 
{
 
    if (i % 3 == 0 && i % 5 == 0)
    {
       Console.ForegroundColor = ConsoleColor.Cyan; 
       Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(i);
    }

}

