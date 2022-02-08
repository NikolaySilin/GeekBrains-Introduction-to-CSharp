// Показать последнюю цифру трёхзначного числа

System.Console.Write("Введите трехзначное число: ");
string _digit = Console.ReadLine();
int _digitInt = Int32.Parse(_digit);

int _lastDigit = _digitInt % 10;

System.Console.WriteLine($"Последнее число трехзначного числа: {_lastDigit}");
