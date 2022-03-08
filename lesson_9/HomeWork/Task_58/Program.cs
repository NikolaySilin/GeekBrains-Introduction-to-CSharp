// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

int rows, columns;
int[,] array = null;
int[,] temporaryArray = null;

void Input(out int rows, out int columns)
{
    System.Console.Write("Введите количество строк: ");
    rows = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов: ");
    columns = int.Parse(Console.ReadLine());
}

void FillArray(out int[,] arr, int rows, int columns)
{
    arr = new int[rows, columns];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void Solution(int[,] arr, ref int[,] tempArr)
{
    tempArr = new int[arr.GetLength(0), arr.GetLength(1)];

    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                tempArr[i, j] = arr[j, i];
            }
        }
        PrintArray(temporaryArray);
    }
    else
    {
        System.Console.WriteLine("Операцию невозможно выполнить! Количество строк не равно количеству столбцов!");
    }

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}

Input(out rows, out columns);
FillArray(out array, rows, columns);
PrintArray(array);
System.Console.WriteLine();
Solution(array, ref temporaryArray);