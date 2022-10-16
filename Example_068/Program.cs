// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Random random = new Random();
int m = random.Next(0,4);
int n = random.Next(0,5);
int s = 0;

Console.WriteLine($"m = {m}, n = {n}");
s = Akkerman(m,n);
Console.WriteLine($"Akkerman = {s}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return (n+1);
    }
    else if (n == 0)
    {
        return Akkerman(m-1,1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m,n-1));
    }
    
}

