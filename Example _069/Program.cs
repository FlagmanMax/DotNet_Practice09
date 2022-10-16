// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Random random = new Random();
int A = random.Next(2,10);
int B = random.Next(2,10);

Console.WriteLine($"A = {A}, B = {B}");
int res = Power(A,B);
Console.WriteLine($"result A^B = {res}");

int Power(int A, int B, int result = 1)
{
    if (B == 0)
    {
        return result;
    }
    
    result *= A;

    B--;
       
    return Power(A,B,result);

}
