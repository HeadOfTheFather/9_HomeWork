/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?)
*/

Console.WriteLine("Enter the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int n = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermannFunction(n - 1, 1);
    else
      return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}
Console.Write($"A({m},{n}) = {AckermannFunction(m,n)}");