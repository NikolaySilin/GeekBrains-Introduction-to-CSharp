// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] array = new int[4, 8];
int sumRow = 0;
int indexSumMinRow = 0;
int minRow = int.MaxValue;

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void Solution(int[,] arr, int sumRow)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumRow = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow += arr[i, j];
        }

         if (sumRow < minRow)
        {
            minRow = sumRow;
            indexSumMinRow = i;
        }
        System.Console.WriteLine($"Сумма строки {i} = {sumRow}");
    }
    System.Console.WriteLine();

    Console.WriteLine($"Строка с минимальной суммой элементов: {indexSumMinRow}");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[indexSumMinRow, j],3} |");
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"{i}: ");

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Solution(array, sumRow);

