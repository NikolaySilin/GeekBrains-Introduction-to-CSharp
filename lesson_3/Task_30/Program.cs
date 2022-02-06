// Показать кубы чисел, заканчивающихся на четную цифру

int[] array = new int[10];
//int[] arr = {1, 2, 3, 4, 5};

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);

    if (array[i] % 2 == 0)
    {
            System.Console.WriteLine($"{array[i]} {Math.Pow(array[i],3)}");
    }
}



