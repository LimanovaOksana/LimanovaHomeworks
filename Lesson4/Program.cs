
/*Урок 4. Функции продолжение
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Exp(double NumA, double NumB)
{
  double result = 1;
  for(double i=1; i <= NumB; i++)
  {
    result = Math.Pow(NumA, NumB);
  }
    return result;
}

  Console.Write("Input number A: ");
  double NumA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input number B: ");
  double NumB = Convert.ToInt32(Console.ReadLine());

  double ExpAB = Exp(NumA, NumB);
  Console.WriteLine($"A^B = {ExpAB}");


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;  
    }
    return sum;

}
Console.Write("Input a number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {A} is {FindSum(A)}");

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 8);
        index++;
    }
}
 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
 
int[] array = new int[8];
 
FillArray(array);
PrintArray(array);

