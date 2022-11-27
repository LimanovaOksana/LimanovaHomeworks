
// Урок 9. Как не нужно писать код. Часть 3
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
/* Выполнить с помощью рекурсии.

void ShowNumbers(int n)

{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}

Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumOfNatural(int m, int n)
{
    if (n >= m) return SumOfNatural(m + 1, n) + m;
    return 0;
}
Console.WriteLine("Add the first natural number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add the second natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of natural elements from {m} to {n} is: {SumOfNatural(m, n)}");



/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)

{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Add the first number > 0: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add the second number > 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The Akkerman's function ({m},{n}) is {Akkerman(m, n)}");
*/



