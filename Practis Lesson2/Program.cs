// Задача 1:
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Квадрат в ОБЕ стороны.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

using System.Globalization;

Console.WriteLine("Задача 1 ");
Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2 || number2 == number1*number1)
{
    Console.WriteLine("Да");
}
else
    Console.WriteLine("Нет");


// Задача 2: Напишите программу, которая принимает на вход
//  координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.


Console.WriteLine("Задача 2 ");
Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату У: ");
int y = Convert.ToInt32(Console.ReadLine());

 if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
    else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во 2 четверти");
}
    else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
    else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
    

// Задача 3: Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 91 => Третьей цифры нет

Console.WriteLine("Задача 3 ");
Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 double lenght =(int)Math.Log10((double)number) + 1;

if (lenght < 3) 
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{   int a = number;
    int b = 0; 
    int i = 0;
    while (i < (lenght - 2))
 {
    b = a%10;
    a = a/10;
    // Console.WriteLine(a);
    // Console.WriteLine(b);
    i++;
}
 Console.WriteLine(b);
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

Console.WriteLine("Задача 4 ");
Console.WriteLine("Введите число: ");
 int number4 = Convert.ToInt32(Console.ReadLine());
 double lenght4 =(int)Math.Log10((double)number4) + 1;

{   int a4 = number4;
    int b4 = 0; 
    int i4 = (int) lenght4;
    string digits = String.Empty;
    while (i4 > 0 )
 {
    b4 = a4%10;
    a4 = a4/10;
    digits = b4.ToString() + "\t" + digits;
    
    i4--;
}
Console.Write(digits);
}
