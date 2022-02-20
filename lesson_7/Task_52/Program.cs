// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
            arr[i, j] = new Random().Next(-100,100);
        }
    }
}

void Solve(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (int) Math.Pow(array[i, j], 2);
            }
        }
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

Input(out x, out y);
FillArray(x, y);
PrintArray(arr);
System.Console.WriteLine();
Solve(arr);
PrintArray(arr);