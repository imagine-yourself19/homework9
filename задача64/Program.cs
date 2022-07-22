void PrintNumbers(int n, int m)
{
    if (n != (m-1))
    {
        PrintNumbers(n - 1, m);
        Console.Write(n + " ");
    }
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n, m);
