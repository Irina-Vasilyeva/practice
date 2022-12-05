// Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Input number or stop: ");
int count = 0;
while (true)
{
    Console.Write("");
    string s = Console.ReadLine()!;
    if (s == "stop")
        break;
    else
    {
        int number = Convert.ToInt32(s);
        if (number > 0)
            count += 1;
    }    
}
Console.WriteLine ($"You entered {count} numbers greater than zero");


// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2*x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1*x + b1
// y = k2*x + b2
// k1*x + b1 = k2*x + b2
// k1*x - k2*x = b2 - b1
// x (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)
/*
double PointX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 1);
    return x;
}

double PointY (double x, double b1, double k1)
{
    double y = k1*x + b1;
    y = Math.Round(y, 1);
    return y;
}

Console.WriteLine ("Input B1 of first line: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input K1 of first line: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input B2 of second line: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input K2 of second line: ");
double num4 = Convert.ToDouble(Console.ReadLine());

if (num1 == num3 && num2 == num4)
    Console.WriteLine ("Lines are exactly the same");
else
    {
        if (num2 == num4)
            Console.WriteLine ("No intersection points");
        else
        {
            double new_x = PointX (num1, num2, num3, num4);
            double new_y = PointY (new_x, num1, num2);
            Console.WriteLine ($"Point of intersection of two lines = {new_x}; {new_y}");
        }
    }
*/   
