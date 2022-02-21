// В двумерном массиве n×k заменить четные элементы на противоположные

double[,] arr = new double[2, 3];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-1000, 1000) * 0.1;
        if (arr[i, j] % 2 == 0)
        {
            arr[i, j] = arr[i, j] * -1;
        }

        System.Console.WriteLine("a[{0},{1}] = {2,6:F2}", i, j, arr[i, j]);
    }
    System.Console.WriteLine();
}