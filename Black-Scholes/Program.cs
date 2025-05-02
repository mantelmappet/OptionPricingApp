namespace Black_Scholes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Calculate(22.75,31.55,3.5,0.05, 0.5));
    }
}