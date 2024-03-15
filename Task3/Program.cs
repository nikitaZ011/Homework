// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void PrintReverseArray(int[] array, int lenght)
{
    if (lenght != 0)
    {
        Console.Write($"{array[lenght - 1]} ");
        PrintReverseArray(array, lenght - 1);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] CreateArrayRndInt(int size, int min, int max)  // параметры
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int[] myArray = CreateArrayRndInt(6, 0, 50);

PrintArray(myArray);

Console.WriteLine();

PrintReverseArray(myArray, myArray.Length);



