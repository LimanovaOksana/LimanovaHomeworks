

// Урок 3. Массивы и функции в программировании
/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 
void FindPalindrome(int a, int b, int c, int d, int e )
{
    if(a == e && b == d)
    {
        Console.WriteLine("The number is a palindrome");
    }
    else
    {
        Console.WriteLine("The number is not a palindrome");
    }
}
Console.WriteLine("input a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input c ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input d ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input e ");
int e = Convert.ToInt32(Console.ReadLine());
FindPalindrome(a,b,c,d,e);
*/
 
/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
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
double lenght = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Show {Math.Round(lenght,2)}");
*/
 
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 
void Cube(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine(Math.Pow(current, 3));
        current++;
    }
}
Console.WriteLine("input number ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);

