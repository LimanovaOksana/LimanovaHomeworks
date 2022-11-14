
/* Урок 5. Функции продолжение
// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int EvenNumber(int[] array)
{
    int even = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        even++;
    }
    return even;
}
Console.Write("input numbers of elements: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(numbers);
ShowArray(myArray);
int evenNumber = EvenNumber(myArray);
Console.WriteLine($"Array has {evenNumber} even numbers");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100); // ограничила массив данным диапазоном, потому что без ограничения выходили слишком большие значения
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 1; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int OddSum(int[] array)

{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("input numbers of elements: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(numbers);
ShowArray(myArray);
int OddNumbers = OddSum(myArray);
Console.WriteLine($"Sum of odds elements is {OddNumbers}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 3) + " ");
    Console.WriteLine();
}

double FindDifference(double[] array)
{
    int numMin = 0;
    int numMax = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[numMin])
            numMin = i;
        if(array[i] > array[numMax])
            numMax = i;
    }
    Console.WriteLine($"Max number of array: {Math.Round(array[numMax], 3)}; min number of array: {Math.Round(array[numMin], 3)}.");
    double diff = array[numMax] - array[numMin];
    return diff;
}
Console.WriteLine("Add numbers of array: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n);
Console.Write("Result: ");
ShowArray(myArray);
double difference = FindDifference(myArray);
Console.WriteLine($"The difference between max and min numbers of array is {Math.Round(difference, 3)}");

