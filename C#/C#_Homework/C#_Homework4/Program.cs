// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void Degree (int a, int b)
{
    int res = a;
    for (int count = 1; count < b; count ++)
    {
        res *= a;
    }
    Console.WriteLine($"Number {a} to power {b} is {res}");
}

Console.WriteLine ("Input number A: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
secondNum = Math.Abs(secondNum);

Degree (firstNum, secondNum);
*/

// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void Sum (int num)
{
    int sign;
    int sum = 0;
    while (num > 0)
    {
        sign = num % 10;
        sum += sign;
        num = num / 10;
    }
    Console.WriteLine($"Sum of digits in number is {sum}");
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
Sum(number);
*/

// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NewArray (int min, int max)
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
        arr[i] = new Random().Next (min, max+1);
    return arr;
}
 void FinalArray (int[] array)
 {
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
 }

 Console.WriteLine("Input min value of elements: ");
 int minValue = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input max value of elements: ");
 int maxValue = Convert.ToInt32(Console.ReadLine());

 int[] array = NewArray (minValue, maxValue);
 FinalArray (array);