// See https://aka.ms/new-console-template for more information
namespace method_exercises;

internal class Program
{ 
 public static void Main(string[] args)
    {
        // Exercise 1
        //Method.MadLib();

        // Exercise 2
        var sum = MathIsFun.Add(2, 3);
        var difference = MathIsFun.Subtract(2, 3);
        var multiply = MathIsFun.Multiply(2, 3);
        var divide = MathIsFun.Divide(2, 5);
        var isEven = MathIsFun.Even(7);

        Console.WriteLine(sum);
        Console.WriteLine(difference);
        Console.WriteLine(multiply);
        Console.WriteLine(divide);
        Console.WriteLine(isEven);
    }
}