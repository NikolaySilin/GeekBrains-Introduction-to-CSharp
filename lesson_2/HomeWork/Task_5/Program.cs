// Найти максимальное из трех чисел

System.Console.Write("Введите первое число: ");
string firstDigit = Console.ReadLine();
int firstDigitInt = Int32.Parse(firstDigit);

System.Console.Write("Введите второе число: ");
string secondDigit = Console.ReadLine();
int secondDigitInt = Int32.Parse(secondDigit);

System.Console.Write("Введите третье число: ");
string thirdDigit = Console.ReadLine();
int thirdDigitInt = Int32.Parse(thirdDigit);

int max = firstDigitInt;

if(secondDigitInt > max) max = secondDigitInt;

if(thirdDigitInt > max) max = thirdDigitInt;

System.Console.WriteLine($"Максимальное число из 3х чисел: {max}");






