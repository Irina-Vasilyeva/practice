// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
void MetFindSum (int a)
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
        summa += current;   // summa = summa + current
    }
    Console.WriteLine($"Summ of elements from 1 to {a} is {summa}");
}

Comsole.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

MetFindSum(user_num);
*/
/*
int MetFindSum2 (int a)
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
        summa += current;
    }
    return summa;
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int result = MetFindSum2(user_num);

Console.WriteLine($"Summ of elements from 1 to {user_num} is {result}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountOfDigits (int number)
{
    int current = 1;
    while (number >= 10)
    {
        number = number / 10;
        current ++;
    }
    return current;
}
Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count_digits;
int user_num1 = (-1) * user_num;
if (user_num >= 0)
    count_digit = CountOfDigits(user_num);
else 
              // += *= -= user_num = user_num * (-1)
    count_digit = CountOfDigits(user_num1);

Console.WriteLine($"Entered number {user_num} -> {count_digit}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
void Factorial (int n)
{
    int multi = 1;
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
    Console.WriteLine($"{n} -> {multi}");
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    while (number <= 0)
    {
        Console.WriteLine("Pls, input POSITIV int number");
        number = Convert.ToInt32(Console.ReadLine());
    }
}
Factorial(number);
*/

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] CreatNewArray (int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 2);    // (0,10)-числа от 0 до 9 включистельно   (min, max+1)
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}

Console.Write("Input count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreatNewArray(count_of_elem);
ShowArray(array1);
// или:
// ShowArray(CreatNewArray(count_of_elem));

//
// int [] CreatNewArray (int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(min, max+1);
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write (array[i] + " ");
// }

// Console.Write("Input count of elements: ");
// int count_of_elem = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreatNewArray(count_of_elem, minValue,maxValue);
// ShowArray(array1);