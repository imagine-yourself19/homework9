void SumOfNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма чисел от m до n равна {sum}");
        return;
    }
    sum += m++;
    SumOfNumbers(m, n, sum);
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumOfNumbers(m, n, sum);
