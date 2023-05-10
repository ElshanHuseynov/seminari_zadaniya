// //Пользователь вводит с клавиатуры M чисел. 
// //Посчитайте, сколько чисел больше 0 ввёл пользователь.
using System;

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();


//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значения k1, b1, k2 и b2:");

double k1 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);



    