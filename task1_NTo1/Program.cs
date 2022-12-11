/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int number = ReadInt("Введите N: ");
int m = 1;
Console.WriteLine(NaturalNumber(number, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
    {
        Console.Write(NaturalNumber(n, m + 1) + ", ");
    }
    return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

