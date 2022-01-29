Console.Clear();

int _xa = 40, _ya = 1;

int _xb = 1, _yb = 30,
    _xc = 80, _yc = 30;

Console.SetCursorPosition(_xa, _ya);
Console.WriteLine("+");

Console.SetCursorPosition(_xb, _yb);
Console.WriteLine("+");

Console.SetCursorPosition(_xc, _yc);
Console.WriteLine("+");

int x = _xa, y = _xb;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + _xa)/2;
        y = (y + _ya)/2;
    }

    if(what == 1)
    {
        x = (x + _xb)/2;
        y = (y + _yb)/2;
    }

    if(what == 2)
    {
        x = (x + _xc)/2;
        y = (y + _yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}