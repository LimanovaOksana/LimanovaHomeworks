

// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
      Console.Write($"Add number {i + 1}: ");
      array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
int PositiveNumbers(int[] array)
{
    int pos = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        pos++;
    }
    return pos;
}
Console.Write("Input a number of elements: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(M);
ShowArray(myArray);
int PositiveNum = PositiveNumbers(myArray);
Console.WriteLine($"Array has {PositiveNum} numbers > 0");
 

/* Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void LineCross(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 == b2) 
        Console.WriteLine("Lines coincide");
    else if(k1 == k2) 
        Console.WriteLine("Lines are parallel and don't cross");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"Lines cross in a point with coordinates ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }
}
Console.WriteLine("Add value b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add value k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add value b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add value k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

LineCross(b1, k1, b2, k2);
*/