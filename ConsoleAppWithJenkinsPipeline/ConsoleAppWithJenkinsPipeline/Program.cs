// See https://aka.ms/new-console-template for more information
Program.Run();

public partial class Program
{
    public static void Run()
    {
        Console.WriteLine("Hello, First testing Jenkins with .Net console!");

        var x = 10;
        var y = 20;
        var sum = MathHelper.Add(x, y);
        Console.WriteLine($"The sume is: {sum}");
    }
}

public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}