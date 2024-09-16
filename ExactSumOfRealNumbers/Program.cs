
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            sum += numbers;
        }
        Console.WriteLine(sum);
    }
}
