using System.Security.Cryptography;

namespace SelStatement2._0;

class Program
{
    static void Main(string[] args)
    {
        //if-else statement
        
        bool condition = false;

        // if (!condition)
        // {
        //     Console.WriteLine("If scope");
        // }
        // else
        // {
        //     Console.WriteLine("Else scope");
        // }

        int a = 200;
        int b = 20;

        if (a == b)
        {
            Console.WriteLine("If scope");
        }
        else if (a > b)
        {
            Console.WriteLine("1st else if");
        }
        else
        {
            Console.WriteLine("Else");
        }
        
        //ternary operator (inline if statement)
        int i = 1;
        string message = i > 0 ? "Positive" : "Negative";
        Console.WriteLine(message);

        Console.WriteLine(i > 0 ? "Positive" : "Negative");
        
        //switch case statement
        
        string today = "Thursday";

        switch (today.ToLower())
        {
            case "sunday":
                Console.WriteLine("It is Sunday");
                break;
            case "monday":
                Console.WriteLine("It is Monday");
                break;
            case "tuesday":
                Console.WriteLine("It is Tuesday");
                break;
            case "wednesday":
                Console.WriteLine("It is Wednesday");
                break;
            case "thursday":
            case "thurs":    
                Console.WriteLine("It is Thursday");
                break;
            case "friday":
                Console.WriteLine("It is Friday");
                break;
            case "saturday":
                Console.WriteLine("It is Saturday");
                break;
            default:
                Console.WriteLine("That's not a day of the week");
                break;
        }
    }
}