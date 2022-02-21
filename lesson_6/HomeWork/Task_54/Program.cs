// В матрице чисел найти сумму элементов главной диагонали

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

void Solution(int[,] array)
{
    int sumMainDigonal = 0;
    int sumSecondaryDiagonal = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if(i == j)
            {
                sumMainDigonal += array[i, j];
            }

            if((i + j) == array.GetLength(1) - 1)
            {
                sumSecondaryDiagonal += array[i, j];
            }
        }
    }
    System.Console.WriteLine($"Сумма чисел по главной диагонали: {sumMainDigonal}");
    System.Console.WriteLine($"Сумма чисел побочной диагонали: {sumSecondaryDiagonal}");
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
Solution(arr);