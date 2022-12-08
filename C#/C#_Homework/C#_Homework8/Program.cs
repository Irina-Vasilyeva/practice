// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:            В итоге получается вот такой массив:
// 1 4 7 2                            7 4 2 1
// 5 9 2 3                            9 5 3 2
// 8 4 2 4                            8 4 4 2
/*
int[,] CreateMatrix (int row, int column, int min, int max)
{
    int[,] matrix = new int[row,column];
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

int[,] SortedMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sortNum;
            for (int jSort = 0; jSort < array.GetLength(1)-1; jSort++)
            {
                if (array[i,jSort] < array[i,jSort+1])
                {
                    sortNum = array[i,jSort];
                    array[i,jSort] = array[i,jSort+1];
                    array[i,jSort+1] = sortNum;
                }
            }
        }
        
    }
    return array;
}

int numberRows = 4;
int numberColumns = 7;
int minValue = 1;
int maxValue = 9;

int[,] matrix = CreateMatrix (numberRows, numberColumns, minValue, maxValue);
Console.WriteLine("Given two-dimensional array:");
ShowMatrix (matrix);
int[,] sortMatrix = SortedMatrix (matrix);
Console.WriteLine("Array is sorted in descending order of elements:");
ShowMatrix (sortMatrix);
*/

// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateMatrix (int row, int column, int min, int max)
{
    int[,] matrix = new int[row,column];
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

int[] Sum (int [,] array)
{
    int size = array.GetLength(0);
    int[] sumElements = new int [size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        sumElements[i] = sum;
    }
    return sumElements;
}

void MinSum (int[] array)
{
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[iMin])
        {
            iMin = i;
        }
    }
    Console.WriteLine($"Row index with smallest sum of elements {iMin}, it is {iMin + 1} row number");
}

int numberRows = 4;
int numberColumns = 5;
int minValue = 1;
int maxValue = 9;

int[,] matrix = CreateMatrix (numberRows, numberColumns, minValue, maxValue);
ShowMatrix (matrix);
int[] sum = Sum (matrix);
MinSum (sum);
*/

// Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int[,] CreateSpiralMatrix (int row, int column)
{
    int[,] spiralMatrix = new int[row, column];
    int number = 11;
    int iMin = 0;
    int jMin = 0;
    int iMax= row;
    int jMax = column;
    while (iMin < iMax && jMin < jMax)   //0<5, 0<5
    {
        int i = iMin;
        int j = jMin;
        for (j = jMin; j <jMax; j++)
        {
            spiralMatrix[i,j] = number;
            number++;
        }
        j = jMax - 1;
        for (i = iMin+1; i <iMax; i++)
        {
            spiralMatrix[i,j] = number;
            number++;
        }
        i = iMax-1;
        for (j = jMax-2; j >= jMin; j--)
        {
            spiralMatrix[i,j] = number;
            number++;
        }
        j = jMin;
        for (i = iMax-2; i > iMin; i--)
        {
            spiralMatrix[i,j] = number;
            number++;
        }
    iMin++;
    jMin++;
    iMax--;
    jMax--;
    }
    return spiralMatrix;
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

int numberRows = 4;
int numberColumns = 4;

int[,] spiral = CreateSpiralMatrix (numberRows, numberColumns);
Console.WriteLine("Spiral filled array:");
ShowMatrix (spiral);
*/


// Задача 58(дополнительно)
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Определение. Произведением двух матриц А и В называется матрица С, 
// элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
// равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.
// В общем случае функция матричного умножения описывается как: 
// C[i,j] = a*C[i,j] + b*Sum(A[i,k]*B[k,j]); Где матрица A имеет размер M х K, матрица B — K х N, и матрица C — M х N
// Произведение матрицы А на матрицу В обозначается АВ.
//Операция умножения двух матриц выполнима только в том случае, 
//если число столбцов в первом сомножителе равно числу строк во втором; !!! A[row,column] B[column,column1] C[row,column1]
//в этом случае говорят, что матрицы согласованы.                              i     j        j      n         i     j

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

int[,] ProductMatrix (int[,] array, int [,] array1)
{
    int[,] matrix = new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < array.GetLength(1); n++)
            {
                sum = sum + array[i,n] * array1[n,j];
            }
            matrix[i,j] = sum;
        }
    }
    return matrix;
}

int numberRows = 4;
int numberColumns = 3;
int numberColumns1 = 2;
int minValue = 1;
int maxValue = 3;

int[,] matrixA = CreateMatrix (numberRows, numberColumns, minValue, maxValue);
int[,] matrixB = CreateMatrix (numberColumns, numberColumns1, minValue, maxValue);
ShowMatrix (matrixA);
ShowMatrix (matrixB);
int[,] matrixC = ProductMatrix (matrixA, matrixB);
Console.WriteLine("Matrix multiply is:");
ShowMatrix (matrixC);




// Задача 60(дополнительно)
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)