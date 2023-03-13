//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    Console.WriteLine(i);
    return sum;
}



Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
//GetSum(n);
int result = GetSum(n);
Console.WriteLine($"Сумма от 1 до {n} равна {result}");