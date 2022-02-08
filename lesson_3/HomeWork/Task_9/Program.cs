// Показать четные числа от 1 до N

List<int> _list = new List<int>(); 

System.Console.Write("Введите первое любое положительное число: ");
string _firstDigit = Console.ReadLine();
int _firstDigitInt = Int32.Parse(_firstDigit);

System.Console.Write("Введите второе любое положительное число: ");
string _secondDigit = Console.ReadLine();
int _secondDigitInt = Int32.Parse(_secondDigit);

for (int i = _firstDigitInt; i < _secondDigitInt + 1; i++)
{
    if(i % 2 == 0)
    {
        _list.Add(i);
    }
}

System.Console.Write("Четные числа: ");

foreach (var item in _list)
{
    System.Console.Write($"{item} ");
}