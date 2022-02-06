
string s = Console.ReadLine();
string s1 = String.Empty;

/* Вывод строки в консоль
for (int i = 0; i < s.Length; i++)
{
    System.Console.Write(s[i]);
}
*/


// Вывод перевернутой строки в консоль
for (int i = s.Length - 1; i >= 0; i--)
{
    s1 = s1 + s[i];
}
System.Console.WriteLine(s1);