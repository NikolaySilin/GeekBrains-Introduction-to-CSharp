// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int x, y;

int digit;

int[,] arr;

string result;

void InputRowsAndColumns(out int x, out int y)
{
    System.Console.Write("Введите количество строк: ");
    x = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов: ");
    y = int.Parse(Console.ReadLine());
}

void InputNumberPosition(out int digit)
{
    System.Console.Write("Введите число: ");
    digit = int.Parse(Console.ReadLine());
}

void FillArray(int x, int y)
{
    arr = new int[x, y];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
}

void Solve(int[,] array, int inputDigit)
{
    var findDigit = 0;
    int x = 0, y = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == inputDigit)
            {
                findDigit = array[i, j];
                x = i;
                y = j;
            }
        }
    }
    if(findDigit == inputDigit)
    {
        System.Console.WriteLine($"Координаты числа, строка: {x + 1} столбец: {y + 1}");
    }
    else
    {
        System.Console.WriteLine($"Числа {inputDigit} в массиве нет!");
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
    }
}

InputRowsAndColumns(out x, out y);

FillArray(x, y);
PrintArray(arr);

InputNumberPosition(out digit);
Solve(arr, digit);
