// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome (int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num5 = num % 10;
    int num4 = (num % 100) / 10;

    if (num1 == num5 && num2 == num4)
    Console.WriteLine ("Число является палиндромом");
    else Console.WriteLine ("Число не является палиндромом");
}

Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
Palindrome (number);
else Console.WriteLine ("Число не пятизначное!");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double leightAB = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    return leightAB;
}

Console.WriteLine("Input X coordinate of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinate of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance from A to B is {dist:f1}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int num)
{
    int i = 1;
    while (i <= num)
    {
        int res = i * i * i;
        Console.Write($"{res}_");
        i ++;
    }
}

Console.WriteLine ("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
Cube(number);
else Console.WriteLine ("Данное число не является натуральным");
