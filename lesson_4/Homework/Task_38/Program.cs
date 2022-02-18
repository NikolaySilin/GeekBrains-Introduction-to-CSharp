// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] _array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int _result = 0;

for (int i = 0; i < _array.Length; i++)
{
    System.Console.Write($"{_array[i]} ");
    _result += _array[i];
    i++;
    
}

System.Console.WriteLine($"\nРезультат суммы чисел одномерного масссива на нечетной позиции: {_result}");