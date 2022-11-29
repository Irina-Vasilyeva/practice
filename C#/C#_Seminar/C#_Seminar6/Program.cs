// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreateNewArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next (min, max + 1);
    }
    return array;
}

void ShowNewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}

int[] ReverseArray (int[] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = array[i];
        array[i] = array[k - 1 - i];
        array[k - 1 - i] = temp;
    }
    return array;
}

Console.WriteLine ("Input size of array: ");
int count_of_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input min possible of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input max possible of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateNewArray(count_of_elements, minValue, maxValue);
ShowNewArray (newArray);
Console.WriteLine();
int[] reversedArray = ReverseArray (newArray);
ShowNewArray (reversedArray);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).
/*
void Fibonachi(int count, int a, int b)
{
    int[] fibArray = new int[count];
    fibArray[0] = a;
    fibArray[1] = b;
    for (int i = 2; i < count; i++)
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];

    ShowArray(fibArray);
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine ("Input count of elements: ");
int count_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input first element: ");
int first_elem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second element: ");
int second_elem = Convert.ToInt32(Console.ReadLine());

Fibonachi (count_elem, first_elem, second_elem);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.
/*
bool Triangle (int side1, int side2, int side3)  //true, false
{
    if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        return true;
    else return false;
}

Console.WriteLine ("Input first side: ");
int first_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second side: ");
int second_side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input third side: ");
int third_side = Convert.ToInt32(Console.ReadLine());

bool result = Triangle (first_side, second_side, third_side);
if (result == true)
    Console.WriteLine("Triangle exists");
else Console.Write("Triangle does not exists");
*/

/*перевод из десятичной в двоичную:
10| 2
10  5 | 2
(0   4   2 | 2
    (1   2   (1
        (0
1010
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
/*
string BinarSyst (int num)
{
    string binResult = string.Empty;
    while (num != 0)  // пока число не равно нулю
    {
        binResult = num % 2 + binResult;  // 10%2->0 =>binResult=0
        num /=2;                          // 5%2->1 => 1 0                                      
    }
    return binResult;
}

Console.WriteLine ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = BinarSyst(number);
Console.WriteLine($"Your number {number} in binar syst is {res}");
*/

