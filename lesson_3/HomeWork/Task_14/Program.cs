// Выяснить, кратно ли число заданному, если нет, вывести остаток.

System.Console.WriteLine("Введите первое число: ");
string _firstDigit = Console.ReadLine();
int _firstDigitInt = Int32.Parse(_firstDigit);

System.Console.WriteLine("Введите второе число, на какое хотите поделить первое: ");
string _secondDigit = Console.ReadLine();
int _secondDigitInt = Int32.Parse(_secondDigit);

if(_firstDigitInt % _secondDigitInt == 0)
{
    System.Console.WriteLine("Число {0} кратно числу {1}",_firstDigitInt,_secondDigitInt);
}
else
{
    float division = (float)_firstDigitInt / _secondDigitInt;
    System.Console.WriteLine("Число {0} не кратно числу {1}, результат деления: {2}",_firstDigitInt, _secondDigitInt, division);
} 