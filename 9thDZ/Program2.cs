// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > m)
    Console.WriteLine(SumBetweenNandM(n));
if (m > n)
    Console.WriteLine(SumBetweenMandN(m));


int SumBetweenNandM(int n)
{
    {
        if (n == m) return m;
        return n + SumBetweenNandM(n - 1);
    }
}
int SumBetweenMandN(int m)
{
    if (m == n) return n;
    return m + SumBetweenMandN(m - 1);
}