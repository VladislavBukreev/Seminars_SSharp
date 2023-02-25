// Напишите программу, которая принимает на вход число (N) // и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/*Console.Clear();
Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int[] result = new int[N];
for (i = 1; i <= N; i++)
    result[i - 1] = i * i;
for (i=0; i < N; i++)
    Console.Write($"{result[i]} ");
    */

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
    

}
int[] result = new int[m];
for (int j = 0; i <= N; i++)
{
    result[j] = i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}
