//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

int firstPoint = 10;
int secondPoint = 99;

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 150);
    }
}

void findCountInInterval(int[] arr, int fPoint, int sPoint)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(i >= fPoint && i <= sPoint)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

FillArray(array);

findCountInInterval(array, firstPoint, secondPoint);


