// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Random random = new Random();
int M = random.Next(5,11);
int N = random.Next(M,15);
Console.WriteLine($"N = {N}, M = {M}");

Recurse(M,N);

void Recurse(int M, int N)
{
    Console.WriteLine($"M = {M}");
    if (M >= N)
    {
        return;
    }
    M++;
    Recurse(M, N);
}
