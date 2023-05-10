// //Задача 47

// Console.WriteLine("Введите количество строк (m):");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов (n):");
// int n = int.Parse(Console.ReadLine());

// double[,] array = new double[m, n];

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble();
//     }
// }

// Console.WriteLine("Сгенерированный массив:");
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// //Задача 50
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите количество строк (m):");
//         int m = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите количество столбцов (n):");
//         int n = int.Parse(Console.ReadLine());

//         int[,] array = new int[m, n];

//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.WriteLine("Введите значение для элемента [{0}, {1}]:", i, j);
//                 array[i, j] = int.Parse(Console.ReadLine());
//             }
//         }

//         Console.WriteLine("Введенный массив:");
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }

//         Console.WriteLine("Введите позицию элемента для получения его значения:");
//         Console.WriteLine("Введите индекс строки:");
//         int rowIndex = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите индекс столбца:");
//         int colIndex = int.Parse(Console.ReadLine());

//         if (rowIndex >= 0 && rowIndex < m && colIndex >= 0 && colIndex < n)
//         {
//             int element = array[rowIndex, colIndex];
//             Console.WriteLine("Значение элемента [{0}, {1}]: {2}", rowIndex, colIndex, element);
//         }
//         else
//         {
//             Console.WriteLine("Указанный элемент не существует в массиве.");
//         }
//     }
// }
//Задача 52

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

        double[] columnAverages = new double[n];

        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / m;
        }

        Console.WriteLine("Среднее арифметическое для каждого столбца:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Столбец {0}: {1}", j, columnAverages[j]);
        }
    }
}

