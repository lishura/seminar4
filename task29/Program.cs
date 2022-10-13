// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int PrintAndGetNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

void FillArray(int [] array)
{
    int length = array.Length;
    int index = 0;
    int min = PrintAndGetNumber("Введите минимальное ограничение для значений элементов массива ");
    int max = PrintAndGetNumber("Введите максимальное ограничение для значений элементов массива ");
    while (index<length)
    {
        array[index]=new Random().Next(min,max);
        index++;
    }

}

void PrintArray(int [] arr)
{
    Console.Write("[");
    int len = arr.Length;
    int count=0;
    while (count<(len-1))
    {
        Console.Write(arr[count]+", ");
        count++;
    }
    Console.Write(arr[len-1]+"]");
}

int N = Math.Abs(PrintAndGetNumber("Введите длину массива N "));

int [] array = new int [N];
FillArray (array);
PrintArray (array);



