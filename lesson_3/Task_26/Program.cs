// Возведите число А в натуральную степень B используя цикл

System.Console.WriteLine("Введите число: ");
string digit = Console.ReadLine();
int digitInt = Int32.Parse(digit);

System.Console.WriteLine("Введите степень в которую хотите возвести число: ");
string power = Console.ReadLine();
int powerInt = Int32.Parse(power);

if (powerInt > 0)
{
    System.Console.WriteLine(Math.Pow(digitInt, powerInt));
}



