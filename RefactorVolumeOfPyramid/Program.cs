class Program
{
    static void Main()
    {
        double length, width, heigth, volume = 0;
        Console.Write("Length: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        heigth = double.Parse(Console.ReadLine());
        volume = (length * width * heigth) / 3;
        Console.Write($"Pyramid Volume: {volume:f2}");
    }
}