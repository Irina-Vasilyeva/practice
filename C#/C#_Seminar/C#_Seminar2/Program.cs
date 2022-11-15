//Напишите программу, которая получает на входе двузначное число и показывает наибольшую цифру числа.
//int Digits () - Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int Digits (int number)   // объявление метода Digit, который получает в качестве аргумента целое чило, возвращает тоже целое число
{
    int ed = number % 10;  // поиск единиц в числе
    int dec = number / 10;  // поиск десятков в числе

    int result;
    if (ed > dec){    // сравнение десятки и единицы
        result = ed;   // завершение метода, возвращение в программу единицы
    }
    else result = dec;

    return result;  // вызов метода с аргументом user-num
}

Console.Write("input your 2digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int res = Digits (user_num);

Console.Write($"The biggest digit is {res}");

// Console.Write("input your 2digit number: ");
// int user_num1 = Convert.ToInt32(Console.ReadLine());
// Digits (user_num1);
// Console.Write("input your 2digit number: ");
// int user_num2 = Convert.ToInt32(Console.ReadLine());
// Digits (user_num2);
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int Digits ()   // объявление метода Digit, который получает в качестве аргумента целое чило, возвращает тоже целое число
{
    int randomNum = new Random().Next(10, 100);   // генерация случайного числа, число 100 не включается
    Console.WriteLine("Your number is" + randomNum);

    int ed = randomNum % 10;  // поиск единиц в числе
    int dec = randomNum / 10;  // поиск десятков в числе

    if (ed > dec){    // сравнение десятки и единицы
        return ed;   // завершение метода, возвращение в программу единицы
    }
    else return dec;
}

Console.Write("The biggest digit is" + Digits());
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
void Cratnost(int num, int a, int b)  // num = user_num, a = divider1, b = divider2
{
    if (num % a == 0 && num % b == 0)  // проверка на кратность
    {
        Console.WriteLine($"Your number {num} is multiple of {a} и {b}");
    }
    else Console.WriteLine($"Your number {num} is not multiple of {a}");
}
// запрос данных у пользователя
Console.Write("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 1 divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 2 divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());
// вызов метода
Cratnost(user_num, divider1, divider2);
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DeleteDec()
{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine("Your number is " + randomNum);

    int fut_dec = randomNum / 100;  // деление нацело
    int fut_ed = randomNum % 10;   // деление с остатком

    int new_num = fut_dec * 10 + fut_ed;
    return new_num;
}

Console.WriteLine($"Your new number is {DeleteDec()}");
*/



// N = 1 * 2 * 3 * ... * (N-1) * N

int Factorial(int a)
{
    int N = 1;
    int num = 1;
    while( num <= a)
    {
        N = N * num;
        num = num + 1;
    }
        return N;
}
  
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
{
    Factorial(number);
    Console.WriteLine($"Факториал {number} равен {Factorial(number)}");
}
else {Console.WriteLine("Факториал для данного числа невозможен");
}
