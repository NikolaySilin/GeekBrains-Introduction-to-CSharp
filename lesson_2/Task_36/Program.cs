// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

int[] array = new int[9];

int count1 = 0;
int count2 = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);

    if (array[i] % 2 == 0)
    {
        count1++;
    }
    else
    {
        count2++;
    }

    System.Console.Write(" " + array[i]);
}

System.Console.WriteLine("\nКол-во четных: " + count1);
System.Console.WriteLine("Кол-во нечетных: " + count2);
