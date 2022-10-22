
/* Урок 2. Массивы и функции в программировании
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)
{
    int dec = number / 10 % 10;
    return dec;
}
Console.WriteLine("Input a num ");
int num = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");
*/


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int FindNumber(int number)
{
    while(number >= 1000)
{
    number = number / 10;
}
number = number % 10;
return number;
}
Console.WriteLine("Input a num ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("no third digit ");
}
else
{
    int result = FindNumber(num);
    Console.WriteLine($"New version of a number {num} is {result}");
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void DayOfTheWeek(int DayNumber)
{
    if(DayNumber == 6 || DayNumber == 7)
    {
       Console.WriteLine("This day is a day off");
    }
    else
    if(DayNumber < 1 || DayNumber > 7)
    {
       Console.WriteLine("This day is unreal");
    }
    else
    {
        Console.WriteLine("This day is not a day off");
    }
}
    Console.WriteLine("Input a number of a day ");
    int DayNumber = Convert.ToInt32(Console.ReadLine());
    DayOfTheWeek(DayNumber);
*/