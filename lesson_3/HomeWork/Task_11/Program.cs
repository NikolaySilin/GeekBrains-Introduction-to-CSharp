// Показать вторую цифру трёхзначного числа

System.Console.Write("Введите трехзначное число: ");
string _digit = Console.ReadLine();
int _digitInt = Int32.Parse(_digit);

int _lastDigit = 0;

if(_digitInt > 100)
{
    _lastDigit = _digitInt / 10;
}

_lastDigit = _lastDigit % 10;

System.Console.WriteLine($"Второе число трехзначного числа: {_lastDigit}");