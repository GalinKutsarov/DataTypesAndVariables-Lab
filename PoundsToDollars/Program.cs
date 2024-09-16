class Program
{
    static void Main()
    {
        double pounds = double.Parse(Console.ReadLine());

        double poundsInDollars = (double)pounds * 1.31;

        Console.WriteLine($"{poundsInDollars:f3}"); 
    }
}