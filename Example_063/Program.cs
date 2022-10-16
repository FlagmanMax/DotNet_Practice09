// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Random random = new Random();
int n = random.Next(5,11);
Console.WriteLine($"n = {n}");

int counter = 1;
Recurse(n, counter);

void Recurse(int n, int counter)
{
    Console.WriteLine($"n = {counter}");
    if (counter >= n)
    {
        return;
    }
    counter++;
    Recurse(n, counter);
}
