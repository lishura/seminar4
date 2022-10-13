// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Применять Math.Pow нельзя!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//функция ввода числовых данных
double PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    double value = double.Parse(input);
    return value;
}

//функция возведения в степень
double Exp(double a, double b)
{
    double E = 1;

    if (b == 1)
    {
        E = a;

    }
    if (b > 1)
    {
        for (int i = 0; i < b; i++)
        {
            E = E * a;
        }
    }
    return (E);
}

double A = PrintAndGetValue("Введите число A ");

double B = Math.Abs(Math.Round(PrintAndGetValue("Введите число B ")));

double E = Exp(A, B);

Console.Write("Число А в натуральной степени В равно " + E);