// Найти максимальное число из трех чисел.

int a = 2, b = 5, c = 9;

int max = a;

if (b > max) max = b;
if (c > max) max = c;

System.Console.WriteLine("Максимальное число: " + max);