// See https://aka.ms/new-console-template for more information
for (int row = 0; row < 10; row++)
{
    for (int col = 1; col <= 10; col++)
    {
        int number = (row * 10) + col;

        if (IsPrimeNumber(number))
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.Write("\t" + number);
    }

    Console.WriteLine();
}

Console.ReadKey();

static bool IsPrimeNumber(int number)
{
    if (number <= 1)
        return false;

    for (int i = 2; i <= (number / 2); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}
