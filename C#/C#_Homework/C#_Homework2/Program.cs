//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Digits (int number)  //321
{
    int twodigit = number % 100;   // 21
    int second = twodigit / 10;
    
    return second;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int result = Digits (num);
    Console.WriteLine($"Вторая цифра {result}");
}
else Console.WriteLine("Число не трехзначное");
*/

//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Digits (int num)
{
   while (num > 999)
   {
    num = num / 10;
   }
   int res;
   res = num % 10;

   return res;
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number > 99)
{
    int result = Digits (number);
    Console.WriteLine($"Третья цифра заданного числа {result}");
}
else Console.WriteLine("Третьей цифры в заданном числе нет");
*/

//Задача 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Days (int num)
{
    if (num >=1 && num <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной день");
    }
}

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=1 && number <=7){
    Days(number);
}
else Console.WriteLine("Данное число не соответствует дню недели");
