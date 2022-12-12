// Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers (int n)
{
    Console.Write (n + " ");
    if (n > 1) ShowNumbers (n-1);
}
ShowNumbers (8);
*/

// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumMN (int m, int n)
{   
    int sum = 0;                  
    if (Math.Max(m,n) != Math.Min(m,n)) 
    {
        sum = Math.Max(m,n) + SumMN (Math.Max(m,n)-1, Math.Min(m,n));
    }
    else sum = m;
    return sum;
}
int m = 1;
int n = 15;
    
Console.WriteLine ($"Sum of natural elements between {m} and {n} -> {SumMN(m,n)}");
*/

// Задача
// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
/*
string Binary (int num)
{
    string binarNum = string.Empty;
    if (num != 0)
        binarNum = Binary (num/2) + num%2;
    return binarNum;
}

Console.WriteLine ("Input number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string bin = Binary (number);
Console.Write ($"This number in binar system is {bin}");
*/


// Задача 68 (дополнительно)
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
//A(0,m)     =m+1                               |A(0,m) = m+1
//A(n+1,0)   =A(n,1)                            |A(n,0) = A (n-1),1
//A(n+1,m+1) =A(n,A(n+1,m))                     |A(n,m) = A (n-1), A(n,(m-1))

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    {
        if ((n != 0) && (m == 0))
            return Accerman(n - 1, 1);
        else
            return Accerman(n - 1, Accerman(n, m - 1));
    }
}

Console.WriteLine ("Input first positive number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input second positive number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if (num1 >= 0 && num2 >= 0)
{
    int accermanFunction = Accerman(num1, num2);
    Console.WriteLine($"for n = {num1}, m = {num2} -> A(n,m) = {accermanFunction}");
}
else Console.WriteLine("These numbers are not positive");


