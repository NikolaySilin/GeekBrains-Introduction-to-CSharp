// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array;

double max = 0, min = 0;
int sizeArray = 0;

void Input(out int sizeArr)
{
    System.Console.Write($"Введите размер массива: ");
    sizeArr = int.Parse(Console.ReadLine());
}

void FillArray(int sizeArr)
{
    array = new double[sizeArr];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i],8:F2}  |");
    }
}

void Solution(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0)
        {
            min = arr[i];
            max = arr[i];
        }

        if(min >= arr[i])
        {
            min = arr[i];
        }

        if(max <= arr[i])
        {
            max = arr[i];
        }
    }
    System.Console.WriteLine($"Наименьшее число в массиве: {min,5:F2}");
    System.Console.WriteLine($"Наибольшее число в массиве: {max,5:F2}");
    System.Console.WriteLine($"Разница между максимальным и минимальным значением в массиве: {max - min:F2}");
}

Input(out sizeArray);
FillArray(sizeArray);
PrintArray(array);
System.Console.WriteLine();
Solution(array);

