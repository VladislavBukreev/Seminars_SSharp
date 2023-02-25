//28 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.Write($" Произведение чисел от 1 до N = {Multiplication(n)} ");

int Multiplication(int n){
int result = 1;
int i = 2;
if(n < 0)
{
    i = n;
    n = -1;
}
for(; i <= n ; i++) 
result *= i;
return result;
}