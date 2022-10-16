// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Random random = new Random();
int n = random.Next(100,1000);
int s = 0;

Console.WriteLine($"n = {n}");
s = SumNum(n);
Console.WriteLine($"sum = {s}");

int SumNum(int n, int sum = 0)
{
    if (n == 0)
    {
        return sum;
    }
    
    sum += n % 10;
    n /= 10;
    
    return SumNum(n,sum);

}
