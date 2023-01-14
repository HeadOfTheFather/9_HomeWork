/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Enter the first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;

void SumOfNaturalElemets(int M, int N)
{
    if (M >= 0 && N >= 0)
    {
        if (M < N)
        {
            Sum += M + N;
            SumOfNaturalElemets(M+1,N-1);
        }
        else if (M > N)
        {
            Sum += M + N;
            SumOfNaturalElemets(M-1,N+1);
        }  
        else if (M == N)
        {   
            Sum += (M + N)/2;
            Console.WriteLine($"Sum of all natural elements between your numbers is: {Sum}");
        }  
    } 
    else Console.WriteLine("ERROR: One of your number is negative!");
 }
SumOfNaturalElemets(M, N);