// Задача 47 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateMatrix (int row, int column, int min, int max)
{
    double[,] matrix = new double [row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            double num = rnd.Next(min, max+1) + rnd.NextDouble();
            matrix[i,j] = Math.Round (num, 2);
        }
    return matrix;
}

void ShowMatrix (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 5;
int n = 7;
int minValue = -10;
int maxValue = 10;
double[,] fractionalArray = CreateMatrix (m, n, minValue, maxValue);
ShowMatrix (fractionalArray);
*/

// Задача 50 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int[,] CreateMatrix (int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matrix[i,j] = rnd.Next (min, max+1);
    return matrix;
}

void ShowMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine ("Input row index of element's position: ");
int iRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input column index of element's position: ");
int jColumn = Convert.ToInt32(Console.ReadLine());

int numberRows = 5;
int numberColumns = 7;
int minValue = 11;
int maxValue = 30;

int[,] someMatrix = CreateMatrix (numberRows, numberColumns, minValue, maxValue);
ShowMatrix (someMatrix);

if (iRow < numberRows && iRow >= 0 && jColumn < numberColumns && jColumn >=0)
    Console.WriteLine ("Element value =" + someMatrix [iRow, jColumn]);
else Console.WriteLine ("Element does not exist");
*/

// Задача 52 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix (int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matrix[i,j] = rnd.Next (min, max+1);
    return matrix;
}

void ShowMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] CreateAverage (int[,] array)
{
    int size = array.GetLength(1);
    double[] average = new double[size];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double result = sum / array.GetLength(0);
        average[j] = Math.Round (result, 1);
    }
    return average;
}

void ShowAverage (double[] array)
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

int numberRows = 3;
int numberColumns = 4;
int minValue = 1;
int maxValue = 8;

int[,] someMatrix = CreateMatrix (numberRows, numberColumns, minValue, maxValue);
ShowMatrix (someMatrix);

ShowAverage ( CreateAverage (someMatrix));
