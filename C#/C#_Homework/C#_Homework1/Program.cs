//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine ());
if (number1 > number2)
{
    Console.WriteLine($"Большее число {number1}");
    Console.WriteLine($"Меньшее число {number2}");
}
else
{
    Console.WriteLine($"Большее число {number2}");
    Console.WriteLine($"Меньшее число {number1}");
}
*/

//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Введите третье число ");
int number3= Convert.ToInt32(Console.ReadLine ());
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine($"Максимальное число {number1}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {number3}");
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine($"Максимальное число {number2}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {number3}");
    }
}
*/

//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine ());
if (number % 2 == 0)
{
    Console.WriteLine($"Число N - четное");
}
else
{
    Console.WriteLine($"Число N - нечетное");
}
*/

//Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine ("Введите натуральное число N: ");
// int number = Convert.ToInt32(Console.ReadLine ());
// int i = 1;
// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i);
//         i++;
//     }
//     else
//     {
//         i++;
//     }
// }
// Исправлено на:

Console.WriteLine ("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine ());
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
    i++;
}
