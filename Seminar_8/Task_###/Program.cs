// 53 поменять местами первую строчку массива с последней
Console.Clear();
Console.WriteLine("Введите количество строк в массиве -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве -> ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте максимально возможное число -> ");
int rand = int.Parse(Console.ReadLine());

int [,] array = GetArray(rows, columns , 0, rand);
PrintArray(array);
Console.WriteLine();
ExchengeLine(array);
PrintArray(array);


int[,] GetArray(int n, int m, int minValue, int rand)
{
    int[,] result = new int[n,m];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next(minValue , rand);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] ExchengeLine(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
         int a = array[array.GetLength(0)-1, j]; // Создали промежуточную переменную занесли последнюю строку
        array[array.GetLength(0)-1, j] = array[0, j]; // первой строке присвоили последнюю строку
        array[0, j] = a; // вернули значение перемнной(последнюю строку) на первую
}
return array;
}