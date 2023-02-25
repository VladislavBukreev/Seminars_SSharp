//30 Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.



// for (int i = 0; i < array.Length - 1; i++){
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine($"{array[array.Length - 1]}");

int[] GetBinaryArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(2);
    }
    return result;
}

int[] array = GetBinaryArray(40);

Console.WriteLine($"[    {String.Join(", ", array)}     ]");