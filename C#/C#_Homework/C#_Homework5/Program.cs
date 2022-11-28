// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray (int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next (min, max+1);
    return array;
}

void ShowArray (int[] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write (array[i]);
        else Console.Write (array[i] + "  ");
    }
    Console.Write ("]");
}

int Quantity (int[] array)
{
    int amt = 0;
    int i = 0;
    while (i < array.Length)
        {
            if (array[i] % 2 == 0)
            {
                amt ++;
            }
            i++;
        }
    return amt;
}
int for_example = 7;

int[] arr = CreateRandomArray (for_example, 100, 999);
ShowArray (arr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine ($"Количество четных чисел в массиве = {Quantity (arr)}");
*/

// Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateNewArray (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next (min, max +1);
    return array;
}

void ShowArray (int[] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write (array[i]);
        else Console.Write (array[i] + "  ");
    }
    Console.Write ("]");
}

int Total (int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i += 2;
    }
    return sum;
}
int egSize = 10;
int egMin = -20;
int egMax = 20;

int[] arr = CreateNewArray (egSize, egMin, egMax);
ShowArray (arr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine ($"Сумма элементов, стоящих на нечетных позициях = {Total (arr)}");
*/

// Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateNewArray (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random ();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.Next(min, max + 1) + rnd.NextDouble();
        array[i] = Math.Round (num, 2);
    }
    return array;
}

void ShowArray (double[] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write (array[i]);
        else Console.Write (array[i] + "  ");
    }
    Console.Write ("]");
}

double MaxVal (double[] array)
{
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
                maxValue = array[i];
        }
    return maxValue;
}

double MinVal (double[] array)
{
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
                minValue = array[i];
        }
    return minValue;
}

int egSize = 10;
int egMin = 1;
int egMax = 20;

double[] arr = CreateNewArray (egSize, egMin, egMax);
ShowArray (arr);
Console.WriteLine();
Console.WriteLine(MaxVal(arr));
Console.WriteLine(MinVal(arr));
double dif = MaxVal (arr) - MinVal (arr);
double difference = Math.Round (dif, 1);
Console.WriteLine ($"Разница между максимальным и минимальным элементов массива = {difference}");
