int AckermannFunction(int n, int m)
{
    if (n == 0)
        return (m + 1);
    if (m == 0)
        return AckermannFunction(n - 1, 1);
    return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Значение функции Аккермана {AckermannFunction(n, m)}");