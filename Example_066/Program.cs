// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Random random = new Random();
int M = random.Next(5,11);
int N = random.Next(M,21);
Console.WriteLine($"M = {M}, N = {N}");

int sum = 0;
sum = Recurse(M,N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {sum}");

int Recurse(int M, int N, int sum = 0)
{
    if (M > N)
    {
        return sum;
    }
    
    sum += M; 
    M++;

    return Recurse(M++, N, sum);
}
