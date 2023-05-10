//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк (m):");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов (n):");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble();
    }
}

Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк (m):");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов (n):");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Введите значение для элемента [{0}, {1}]:", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Введенный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Введите позицию элемента для получения его значения:");
        Console.WriteLine("Введите индекс строки:");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите индекс столбца:");
        int colIndex = int.Parse(Console.ReadLine());

        if (rowIndex >= 0 && rowIndex < m && colIndex >= 0 && colIndex < n)
        {
            int element = array[rowIndex, colIndex];
            Console.WriteLine("Значение элемента [{0}, {1}]: {2}", rowIndex, colIndex, element);
        }
        else
        {
            Console.WriteLine("Указанный элемент не существует в массиве.");
        }
    }
}
