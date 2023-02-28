//**Задача 39:** Напишите программу,которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();

Console.WriteLine("Введите кол-во символов в массиве ->");
int size = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите Максимальное число в массиве ... ");
int random = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
Console.WriteLine($"Generation res ...  [    {String.Join(", ", array)}     ]");
ReversArray(array);
Console.WriteLine($"Generation res ...  [    {String.Join(", ", array)}     ]");

int[] NewArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++ )
    {
          res[i] = new Random().Next(0, random);

    }
    return res;
}


void ReversArray(int[] array)

{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}



/*
var array = new[]{1,2,3,4,5,6,7};
Array.Reverse(array);
Console.WriteLine(string.Join(" ", array));
*/
