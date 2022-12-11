/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int start = ReadInt("Введите M: ");
int end = ReadInt("Введите N: ");
NaturalNumber(start, end);
Console.WriteLine($"Сумма элементов от {start} до {end} = {NaturalNumber(start, end)}");


int NaturalNumber(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalNumber(m, n - 1);
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}