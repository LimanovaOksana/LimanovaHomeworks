
//Урок 8. Как не нужно писать код. Часть 2

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void StreamlineElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int MaxPos = j;
            for (int a = j + 1; a < array.GetLength(1); a++)
            {
                if (array[i, a] > array[i, MaxPos])
                    MaxPos = a;
            }
            int temp = array[i, j];
            array[i, j] = array[i, MaxPos];
            array[i, MaxPos] = temp;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Array after streamlining");
}

Console.WriteLine();
Console.WriteLine("Array before streamlining");

int[,] my2Array = CreateRandom2Array(5, 5); // Чтобы не вводить данные, я установила размер для массива 5*5
Show2Array(my2Array);

StreamlineElements(my2Array);
Show2Array(my2Array);
*/


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int MinSumRow(int[,] array)
{
    int MinSum = 0;
    int MinSumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        MinSum += array[0, j];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < MinSum)
        {
            MinSumRow = i;
            MinSum = sum;
        }
    }
    return MinSumRow;
}

int[,] my2Array = CreateRandom2Array(5, 5);
Show2Array(my2Array);
int res = MinSumRow(my2Array);
Console.WriteLine($"Min sum of elements in {res+1} row");
*/

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] CreateRandomArray(int rows, int columns)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ProductNumbersArrays(int[,] array1, int[,] array2)
{
    int[,] ProductArrays = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < ProductArrays.GetLength(0); i++)
    {
        for (int j = 0; j < ProductArrays.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += (array1[i,k] * array2[k,j]);
            }
            ProductArrays[i,j] = sum;
        }
    }
    return ProductArrays;
}

Console.Write("Input a number of rows of array 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of array 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray1 = CreateRandomArray(m, n);
Console.WriteLine("First array: ");
ShowArray(myArray1);

Console.Write("Input a number of rows of array 2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of array 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray2 = CreateRandomArray(m2, n2);
Console.WriteLine("Second array: ");
ShowArray(myArray2);


if(n == m2)
{
    int[,] reProductArrays = ProductNumbersArrays(myArray1, myArray2);
    Console.WriteLine("Product of arrays: ");
    ShowArray(reProductArrays);
}
else Console.WriteLine("The product of arrays is not available");

*/


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
/* Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3Array(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void Show3Array(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} (array[{i}, {j}, {k}]); ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

Console.Write("Add amount of tims for showing array: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Add amount of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Add amount of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,,] my3Array = Create3Array(p, n, m);
Show3Array(my3Array);




*/



