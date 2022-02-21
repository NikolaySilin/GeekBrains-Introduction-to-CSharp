// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array;

int sizeArray;

int x = 0, y = 0;

void Input(out int sizeArr)
{
    System.Console.Write("Введите размер массива: ");
    sizeArr = int.Parse(Console.ReadLine());
}

void FillArray(int sizeArr)
{
    array = new int[sizeArr];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i],5}   |");
    }
}

void Solution(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0)
        {
            x = arr[i];
        }
         
         y = arr[i];
    }
    System.Console.WriteLine($"\nПервое: {x}, и последнее: {y}, число в массиве");
    System.Console.WriteLine($"\nИх произведение равно: {x * y}\n");
}

Input(out sizeArray);
FillArray(sizeArray);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
Solution(array);
