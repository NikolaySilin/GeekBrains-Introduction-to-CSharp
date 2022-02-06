// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

int[] arrEven = new int[10];
int[] arrNotEven = new int[10];

int countEven = 0;
int counNotEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0)
    {
        arrEven[countEven] = array[i];
        countEven++;
        System.Console.WriteLine($"Четные числа: {arrEven[countEven - 1]} ");
    }
    else
    {
        arrNotEven[counNotEven] = array[i];
        counNotEven++;
        System.Console.WriteLine($"Не четные числа: {arrNotEven[counNotEven - 1]} ");
    }
}

System.Console.WriteLine($"\nКоличество четных: {countEven}");
System.Console.WriteLine($"Количество не четных: {counNotEven}");