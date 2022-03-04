/*
 Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
 Например для N = 50, M получается 6.

Одно из решений :
Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48

 Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰
 */

List<List<int>> data = new List<List<int>>();

List<int> list = new List<int>();

list.Add(1);
data.Add(list);

bool Check(int n, List<int> list)
{
    foreach(int i in list)
    {
        if(n % i == 0)
        {
            return true;
        }
    }
    return false;
    /*
    for (int i = 0; i < list.Count; i++)
    {
        if(n % list[i] == 0)
        {
            return true;
        }
    }
    return false;
    */
}

System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
stopwatch.Start();
int N = 50;
for (int i = 2; i <= N; i++)
{
    bool isListFinded = false;
    for (int j = 0; j < data.Count && !isListFinded; j++)
    {
        if(!Check(i, data[j]))
        {
            data[j].Add(i);
            isListFinded = true;
            break;
        }
    }
    if(!isListFinded)
    {
        List<int> newList = new List<int>();
        newList.Add(i);
        data.Add(newList);
    }
}

void Print()
{
    int j = 0;
    foreach (List<int> list in data)
    {
        Console.Write((j++) + " ");
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

Print();

stopwatch.Stop();

System.Console.WriteLine("Время выполнения: " + stopwatch.Elapsed.TotalSeconds);