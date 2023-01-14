/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine());
void WriteNto1(int N)
{
    if(N > 0)
    {
        Console.Write($"{N} ");
        WriteNto1(N - 1);
    }
}
WriteNto1(N);