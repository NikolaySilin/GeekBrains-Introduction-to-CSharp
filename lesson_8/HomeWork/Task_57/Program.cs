// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int x = 0, y = 0;

int[,] array;

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

void Solution(int[,] arr)
{
    var sorting = arr.Cast<int>().OrderByDescending(a => a).ToArray();
 
            int c = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = sorting[c];
                    System.Console.Write($"{arr[i, j],7} |");
                    c++;
                }
                System.Console.WriteLine();
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
System.Console.WriteLine();
Solution(array);
System.Console.WriteLine();


