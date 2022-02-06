//Задача 20.2 пробного ГИА от 2016.03.10

/*
Напишите программу для решения следующей задачи. 
На  контрольной  работе  по  алгебре  ученикам 9 класса  было  предложено 
10 примеров.  Неудовлетворительная  оценка  выставляется,  если  правильно 
решено  менее  половины  примеров.  Сколько  неудовлетворительных  оценок 
было получено учениками? Если хотя бы один из учеников правильно решил 
все задачи, выведите YES, иначе – выведите NO. 
Программа получает на вход количество учеников в классе N (1 ≤ N ≤ 30), 
затем  для  каждого  ученика  вводится  количество  правильно  решённых 
примеров. 
*/

System.Console.WriteLine("Введите кол-во учеников: ");

string digit = System.Console.ReadLine();

int n = Int32.Parse(digit);

if (n < 1)
{
    System.Console.WriteLine("Ошибка, учеников меньше 1");
}
else if (n > 30)
{
    System.Console.WriteLine("Ошибка, учеников больше 30");
}
else
{
    int[] arrayOne = new int[n];
    int n1 = 0, n2 = 0, n3 =0;
    for (int i = 1; i < n - 1; i++)
    {
        System.Console.WriteLine("Введите кол-во правильно решенных примеров ученика номер: " + i);
        string value = System.Console.ReadLine();
        
        arrayOne[i] = Int32.Parse(value);

        if (arrayOne[i] > 10)
        {
            System.Console.WriteLine("Ошибка, заданий всего 10");
        }
        else if (arrayOne[i] == 10)
        {
            n1++;
        }
        else if (arrayOne[i] < 10 && arrayOne[i] >= 5)
        {
            n2++;
        }
        else if (arrayOne[i] < 5)
        {
            n3++;
        }
    }
     System.Console.WriteLine(n1 + " ученик(а, ов) решил(и) все заданиея правильно (Yes)");
     System.Console.WriteLine(n2 + " ученик(а, ов) получил(и) удовлетворительную оценку (No)");
     System.Console.WriteLine(n3 + " ученик(а, ов) получил(и) не удовлетворительную оценку (No)");
}
