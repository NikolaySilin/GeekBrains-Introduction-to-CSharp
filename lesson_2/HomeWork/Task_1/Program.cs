// Вывести квадрат числа

System.Console.Write("Введите число: ");

string digit = Console.ReadLine();

int digitInt = Int32.Parse(digit);

System.Console.WriteLine($"Квадрат числа: {Math.Pow(digitInt, 2)}");
