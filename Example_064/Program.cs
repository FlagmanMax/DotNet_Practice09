// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

Random random = new Random();
int M = random.Next(5,11);
int N = random.Next(M,21);
Console.WriteLine($"M = {M}, N = {N}");

Recurse(M,N);

void Recurse(int M, int N)
{
    if (M%3 == 0)
    {
        Console.WriteLine($"M = {M}");
    }
    if (M >= N)
    {
        return;
    }
    M++;
    Recurse(M, N);
}