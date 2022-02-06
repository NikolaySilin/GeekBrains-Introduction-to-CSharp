// По заданному номеру дня недели вывести его название

System.Console.Write("Введите номер дня недели: ");

string digit = Console.ReadLine();
int digitInt = Int32.Parse(digit);

if (digitInt > 1 && digitInt < 8)
{
    switch (digitInt)
    {
        case 1:
            System.Console.WriteLine($"{digit} день недели это Понедельник");
            break;
        case 2:
            System.Console.WriteLine($"{digit} день недели это Вторник");
            break;
        case 3:
            System.Console.WriteLine($"{digit} день недели это Среда");
            break;
        case 4:
            System.Console.WriteLine($"{digit} день недели это Четверг");
            break;
        case 5:
            System.Console.WriteLine($"{digit} день недели это Пятница");
            break;
        case 6:
            System.Console.WriteLine($"{digit} день недели это Суббота");
            break;
        case 7:
            System.Console.WriteLine($"{digit} день недели это Воскресенье");
            break;
    }
}
else
{
    System.Console.WriteLine("Такого дня по счету в недели нет");
}

