
/* Урок 7. Как не нужно писать код. Часть 1
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++) 
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return array;
}

void Show2Array(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 1) + " ");
        Console.WriteLine(); 
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] my2Array = CreateRandom2Array(m, n, min, max);
Show2Array(my2Array);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void PositionElement(int[,] array, int a, int b)
{
    if (a < array.GetLength(0) && b < array.GetLength(1))
        Console.WriteLine("The element in array has position " + array[a, b]);
    else
        Console.WriteLine("there is no such element in the array");
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a position of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a position of columns: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] my2Array = CreateRandom2dArray(m, n);
Show2dArray(my2Array);
PositionElement(my2Array, a, b);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)   
    { 
        for(int j = 0; j < columns; j++)      
        {
            array[i, j] = new Random().Next(1,100); 
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 
        Console.WriteLine(); 
    }
}

double[] AverageColumns(int [,] array)
{
    
    double [] avgArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg += array[i, j];
        }
        avgArray[j] = avg / array.GetLength(0);
    }
    return avgArray;
}

void ShowArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(Math.Round(array[j], 2) + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] my2Array = CreateRandom2Array(m, n);
Show2Array(my2Array);

double [] arrayRes = AverageColumns(my2Array);
Console.WriteLine("Average amount in each columns is: ");
ShowArray(arrayRes);
*/