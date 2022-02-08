// Удалить вторую цифру трёхзначного числа

System.Console.Write("Введите трехзначное число: ");
string _digit = Console.ReadLine();

System.Console.WriteLine("Удаляю вторую цифру! ");

string _remove = _digit.Remove(1,1);

int _digitInt = Int32.Parse(_remove);

System.Console.WriteLine($"Результат: {_digitInt}");

