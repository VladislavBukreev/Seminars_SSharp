// **3адача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.
// **Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Clear();
Console.WriteLine("Введите сторону А -> ... ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону B -> ... ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону C -> ... ");
int c = int.Parse(Console.ReadLine());
 
if(true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");

}


bool Method(int a,int b,int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
