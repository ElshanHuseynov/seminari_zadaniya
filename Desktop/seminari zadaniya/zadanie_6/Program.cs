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
