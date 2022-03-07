// Найти произведение двух матриц

int[,] arrayOne = new int[5, 5];
int[,] arrayTwo = new int[5, 5];
int[,] arrayResult = new int[5, 5];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],5}  |");
        }
        System.Console.WriteLine();
    }
}

void Solution(int[,] firstArr, int[,] secondArr, int[,] arrResult)
{
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < firstArr.GetLength(1); j++)
        {
            arrResult[i, j] = firstArr[i, j] * secondArr[i, j];
        }
    }
}

FillArray(arrayOne);
FillArray(arrayTwo);

PrintArray(arrayOne);
System.Console.WriteLine();
PrintArray(arrayTwo);

Solution(arrayOne, arrayTwo, arrayResult);

System.Console.WriteLine();

PrintArray(arrayResult);