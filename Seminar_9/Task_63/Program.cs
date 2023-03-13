/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.
Решить при помощи рекурсии
N = 5-> "1, 2, 3, 4, 5"
N = 6-> "1, 2, 3, 4, 5, 6"
*/

using System;
using static System.Console;

Clear();
/* ПРИМЕР ЧТО МОЖНО РЕКУРСИЮ ЗАМЕНИТЬ ЦИКЛОМ
 
Write("Введите N: ");
int n = int.Parse(ReadLine());
for (int i = 1; i <= n; i++)    
{
    Write($"{i} ");
}
WriteLine();
*/

WriteLine(PrintNumbers(n));
ReadLine();

string PrintNumbers(int n)
{
    if (n == 1)
    {
        WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(n - 1) + " " + n.ToString();
    WriteLine(s);
    return s;
} 