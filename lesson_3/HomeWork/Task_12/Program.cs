// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int _random = new Random().Next(10,99);

int _firstDigit = 0;
int _secondDigit = 0;


if(_random > 10)
{
    _firstDigit = _random / 10;
}

_secondDigit = _random % 10;

int max = _firstDigit;

if(_secondDigit > max) max = _secondDigit;

System.Console.WriteLine($"Сгенерированное число из промежутка 10 - 99: {_random}");
System.Console.WriteLine($"Первое число: {_firstDigit}");
System.Console.WriteLine($"Второе число: {_secondDigit}");
System.Console.WriteLine($"Наибольшая цифра числа: {max}");


