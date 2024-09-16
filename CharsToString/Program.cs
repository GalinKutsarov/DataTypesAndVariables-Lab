class Program
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());

        string finalWord = "";
        finalWord = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();

        Console.WriteLine(finalWord);
    }
}

