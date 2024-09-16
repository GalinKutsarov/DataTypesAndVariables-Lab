class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int currentDigit = 0;
        bool isSpecialNum = false;
        for (int i = 1; i <= n; i++)
        {
            currentDigit = i;
            while (i > 0)
            {
                sumOfDigits += i % 10;
                i = i / 10;
            }
            isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine($"{currentDigit} -> {isSpecialNum}");
            sumOfDigits = 0;
            i = currentDigit;
        }
    }
}
