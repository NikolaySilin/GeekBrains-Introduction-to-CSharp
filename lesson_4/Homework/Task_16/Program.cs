// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int _digit = 0;
string _dayName = "";

void Input()
{
    System.Console.Write("Введите номер дня недели: ");
    _digit = Int32.Parse(Console.ReadLine());
}

string CheckWeekDay(int dayOfTheWeek)
{
    switch (dayOfTheWeek)
    {
        case 1:
                _dayName = "Понедельник";
                break;
                
        case 2:
                _dayName = "Вторник";
                break;

        case 3:
                _dayName = "Среда";
                break;

        case 4:
                _dayName = "Четверг";
                break;

        case 5:
                _dayName = "Пятница";
                break;

        case 6:
                _dayName = "Суббота";
                break;

        case 7:
                _dayName = "Воскресенье";
                break;                        
    }
    return _dayName;
}

void Output()
{
    System.Console.WriteLine("Вы выбрали {0}", _dayName);
}

Input();
CheckWeekDay(_digit);
Output();

