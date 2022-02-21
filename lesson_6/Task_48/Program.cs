// 

int[,] arr = new int[3, 2] { { 0, 4 }, { 3, 4 }, { 2, 8 } };

/*
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        System.Console.WriteLine($"{i}, {j} = {arr[i,j]}");
    }
}
*/

void Print2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.WriteLine($"{i}, {j} = {arr[i, j],4}");
        }
        System.Console.WriteLine();
    }
}


Print2D(arr);
