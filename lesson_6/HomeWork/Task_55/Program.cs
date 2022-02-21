// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int x, y;

int[,] arr;

void Input(out int x, out int y)
{
    System.Console.Write("Введите количество строк: ");
    x = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов: ");
    y = int.Parse(Console.ReadLine());
}

void FillArray(int x, int y)
{
    arr = new int[x, y];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void Solution(int[,] array, int y)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        System.Console.WriteLine($"Сумма чисел в колонне: {i + 1} равна: {sum}");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],7} |");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

Input(out x, out y);
FillArray(x, y);
PrintArray(arr);
System.Console.WriteLine();
Solution(arr, y);