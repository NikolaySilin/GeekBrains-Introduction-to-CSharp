// Найти третью цифру числа или сообщить, что её нет

System.Console.Write("Введите двухзначное или трехзначное число: ");
string _digit = Console.ReadLine();
int _digitInt = 0;

if(_digit.Length == 3)
{
    _digitInt = Int32.Parse(_digit);
    int lastDigit = _digitInt % 10;
    System.Console.WriteLine("В числе {0} есть третья цифра, эта цифра {1}", _digitInt, lastDigit);
}
else if(_digit.Length == 2)
{
    _digitInt = Int32.Parse(_digit);
    System.Console.WriteLine("В числе {0} нет третьей цифры", _digitInt);
}
else
{
    System.Console.WriteLine("Ошибка");
}

