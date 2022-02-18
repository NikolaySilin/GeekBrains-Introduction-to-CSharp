// Определить, присутствует ли в заданном массиве, некоторое число.

//Создание переменных
//Ввод
//Заполнение массива
//Решение задачи
//Вывод

// Создание переменных
int[] _array;
bool _ask;
int _digit;

// Ввод
void Input()
{
    _array = new int[50];
    _ask = false;
    // Запрос данных от пользователя с консоли
    System.Console.Write("Введите число: ");
    _digit = Int32.Parse(Console.ReadLine());
}

// Заполнение массива
void FillArray(int[] array)
{
    for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(10, 100);
    }
}

// Вывод заполненного массива
void PrintArray(int[] array)
{
    for (int i = 0; i < _array.Length; i++)
    {
        System.Console.Write($"{_array[i]} ");
    }
}

// Решение задачи
void Solve(int[] array)
{
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i] == _digit)
        {
            _ask = true;
        }
    }
}

void Output()
{
     if (_ask)
    {
        System.Console.WriteLine("\nЧисло {0} присутствует в массиве", _digit);
    }
    else
    {
        System.Console.WriteLine("\nЧисло {0} отсутсвует в массиве", _digit);
    }
}

Input();
FillArray(_array);
PrintArray(_array);
Solve(_array);
Output();