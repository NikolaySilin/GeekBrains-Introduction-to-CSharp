// See Показать числа от -N до N

System.Console.Write("Введите любое отрицательное число: ");
string _negativDigit = Console.ReadLine();
int _negativDigitInt = Int32.Parse(_negativDigit);

System.Console.Write("Введите любое положительное число: ");
string _positivDigit = Console.ReadLine();
int _positivDigitInt = Int32.Parse(_positivDigit);

if (_negativDigitInt < 0)
{
    if (_positivDigitInt > 0)
    {
        for (int i = _negativDigitInt; i < _positivDigitInt + 1; i++)
        {
            System.Console.Write($"{i} ");
        }
    }
    else if (_positivDigitInt == 0)
    {
        System.Console.WriteLine("Вы ввели ноль");
    }
    else
    {
        System.Console.WriteLine("Вместо положительного вы ввели отрицательное число!");
    }
}
else if (_negativDigitInt == 0)
{
    System.Console.WriteLine("Вы ввели ноль");
}
else
{
    System.Console.WriteLine("Вместо отрицательного вы ввели положительное число!");
}
