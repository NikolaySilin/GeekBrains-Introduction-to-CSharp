// Дано число. Проверить кратно ли оно 7 и 23

System.Console.Write("Введите любое число: ");
string _digit = Console.ReadLine();
int _digitInt = Int32.Parse(_digit);

int _firstDivision = 7;
int _secondDivision = 23;

float _division = 0f;

if(_digitInt % _firstDivision == 0)
{
    _division = _digitInt / _firstDivision;
    System.Console.WriteLine("Число {0} кратно числу {1}, результат деления: {2}", _digitInt, _firstDivision, _division);
}
else
{
    _division = (float)_digitInt / _firstDivision;
    System.Console.WriteLine("Число {0} не кратно числу {1}, результат деления: {2}", _digitInt, _firstDivision, _division);
}

if (_digitInt % _secondDivision == 0)
{
    _division = _digitInt / _secondDivision;
    System.Console.WriteLine("Число {0} кратно числу {1}, результат деления: {2}", _digitInt, _secondDivision, _division);
}
else
{
    _division = (float)_digitInt / _secondDivision;
    System.Console.WriteLine("Число {0} не кратно числу {1}, результат деления: {2}", _digitInt, _secondDivision, _division);
}
