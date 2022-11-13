
// Урок 3. Массивы и функции в программировании
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/


/*
int[]array = {1,4,8,3,4};

if(array[0] == array[4] && array[1] == array[3])
    {
    Console.WriteLine("палиндром");
    }
    else 
    {
        Console.WriteLine("не палиндром");
    }


void FindNumber(int x, int y, int z, int c, int a )
{
    if(x == a && y == c)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
Console.Write("input x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("input z ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("input c ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("input a ");
int a = Convert.ToInt32(Console.ReadLine());
FindNumber(x,y,z,c,a);

*/

/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double FindNumber(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lenght = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow (y2 - y1, 2) + Math.Pow (z2 - z1, 2));
    return lenght;
}
Console.WriteLine("input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z2");
int z2 = Convert.ToInt32(Console.ReadLine());
double lenght = FindNumber(x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Show {Math.Round(lenght,3)}");
*/