// Написать программу, которая обменивает элементы первой строки и последней строки

int x = 0, y = 0;

int[,] array;
int temp;

void Input(out int x, out int y)
{
    System.Console.Write("Введите количество строк: ");
    x = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов: ");
    y = int.Parse(Console.ReadLine());
}

void FillArray(int x, int y)
{
    array = new int[x, y];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void Solution(int[,] arr, int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[y - 1, i];
        arr[y - 1, i] = temp;
    }
    
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],7} |");
        }
        System.Console.WriteLine();
    }
}

Input(out x, out y);
FillArray(x, y);
PrintArray(array);
Solution(array, x, y);
System.Console.WriteLine();
PrintArray(array);


