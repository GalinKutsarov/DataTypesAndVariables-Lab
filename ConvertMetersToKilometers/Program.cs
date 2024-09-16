class Program
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());

        double metersToKm = (double)meters / 1000;

        Console.WriteLine($"{metersToKm:f2}");
    }
}