//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i,j] = new Random().Next(minVal, maxVal +1);
    return created2dArray;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");   //вывод значений
        }
        Console.WriteLine();   //переход на новую строку
    }
    Console.WriteLine();    //отступ от массива
}

Console.Write ("Input count of row: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray (rows, columns, min, max);
Show2dArray (newArray);
*/

// Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// 2x3
// 0 1 2
// 1 2 3
/*
int[,] Create2dArray (int row, int column)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i,j] = i + j;
    return created2dArray;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Show2dArray (Create2dArray(5, 6));
*/

// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
/*
int[,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i,j] = new Random().Next(minVal, maxVal +1);
    return created2dArray;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] EvenNumbers (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}

int[,] created2dArray = Create2dArray(5,6,-5,10);
Show2dArray(created2dArray);
EvenNumbers (created2dArray);
Show2dArray (created2dArray);
*/

// //Найти сумму элементов главной диагонали

int[,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i,j] = new Random().Next(minVal, maxVal +1);
    return created2dArray;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumNumber (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }

        }
    }
    return sum;
}

int[,] newArray = Create2dArray(3,4,5,10);
Show2dArray(newArray);
int sum = SumNumber(newArray);
Console.WriteLine($"{sum}");
