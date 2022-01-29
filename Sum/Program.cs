int _numberA = new Random().Next(1, 123);
Console.WriteLine("Random generated A: " + _numberA);
int _numberB = new Random().Next(1, 321);
Console.WriteLine("Random generated B: " + _numberB);
int result = _numberA + _numberB;

Console.WriteLine("Summ A + B: " + result);