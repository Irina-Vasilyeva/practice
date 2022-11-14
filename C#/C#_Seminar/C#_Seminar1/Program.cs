//Console.Write("Good morning");
//int number = 11;
//Console.WriteLine("Доброе утро! Сегодня " + number + "ноября");
//Console.WriteLine($"Доброе утро! Сегодня {number} ноября");
//Console.WriteLine("Input your number: ");
//int number = Convert.ToInt32(Console.ReadLine ());

//Console.WriteLine("Input number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int result = number * number;
//Console.WriteLine($"Квадрат {number} равен {result}");

/*Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.WriteLine($"число {number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"число {number1} не является квадратом {number2}");
}

Console.WriteLine("введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);
while (current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000){
    int current = number % 10;
    Console.WriteLine($"последняя цифра числа {number} - {current}");
}
else
{
    Console.WriteLine("Число не трехзначное! ");
}