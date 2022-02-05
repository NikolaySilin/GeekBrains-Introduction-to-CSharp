//Написать программу замену элементов массива на противоположные

int[] array = new int[15];

int number;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);

    System.Console.Write(" " + array[i]);
}

System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i]  *= -1;

    System.Console.Write(" " + array[i]);
}

