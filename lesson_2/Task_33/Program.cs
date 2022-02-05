//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = {-1, 9, -5, 9, -7, 9, -1, 9, -3, 9, 0, 9};

int positiveSum = 0;
int negativeSum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveSum += array[i];
    }
    if (array[i] < 0)
    {
        negativeSum += array[i];
    }
}

System.Console.WriteLine(positiveSum);
System.Console.WriteLine(negativeSum);
