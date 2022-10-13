// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите целое число ");
int n = Math.Abs(int.Parse(Console.ReadLine()));



int SumNumbers(int x)
{
    int count = 0;
    int s = 0;
    while (x > 0)
    {
        s = s + x % 10;
        x = x / 10;
        count++;
    }
    return s;
}


Console.WriteLine(SumNumbers(n));

