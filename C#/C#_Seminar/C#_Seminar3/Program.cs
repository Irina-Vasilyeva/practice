// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
void Funkt(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("This point on 1st quarter");
    else if (x < 0 && y > 0)
        Console.WriteLine("This point on 2nd quarter");
    else if (x < 0 && y < 0)
        Console.WriteLine("This point on 3rd quarter");
    else if (x > 0 && y < 0)
        Console.WriteLine("This point on 4st quarter");
    else Console.WriteLine("it's imposible at this task");
}

Console.WriteLine("Input your X number: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y number: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

Funkt(xCoord, yCoord);
*/

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void PossibleValue(int n)
{
    if (n == 1)
        Console.WriteLine("1st quater X > 0, Y > 0");
    else if (n == 2)
        Console.WriteLine("2nd quater X < 0, Y > 0");
    else if (n == 3)
        Console.WriteLine("3rd quater X < 0, Y < 0");
    else Console.WriteLine("4th quater X > 0, Y < 0");
}

Console.WriteLine("Input number of quater: ");
int numQater = Convert.ToInt32(Console.ReadLine());

if (numQater >= 1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine("it's not number of quater!");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//Math.Sqrt(num);
// A(x1,y1); B(x2,y2)
/*
double LongLine(int x1, int y1, int x2, int y2)
{
    //double lenghtAB = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 3);
    //return lenghtAB;
    // или решение 2
    int x = x2 - x1;
    int y = y2 - y1;
    double lenghtAB = Math.Sqrt(x*x + y*y);
    return lenghtAB;
}

Console.WriteLine("input X coordinate of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinate of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input X coordinate of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinate of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, xB, yB);

//Console.WriteLine($"Distance AB is {dist}");
//решение 2

Console.WriteLine($"Distance AB is {dist:f3}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Quard(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine($"\b\b.");
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Quard(number);
}
else Console.WriteLine("Imposible number!");
*/