// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите значение натурального числа M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение натурального числа N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> \"");
NumbersRange(m, n);
Console.WriteLine("\"");

//if( m<0 || n<0)
// {
//     Console.WriteLine("Некорректный ввод!");
// }


void NumbersRange(int M, int N)
{
    if (M == N)
    {
        Console.Write($"{M}");
        return;
    }
    
    if (M < N)
    {
        Console.Write($"{M}, ");
        NumbersRange(M + 1, N);
    }
    else
    {
        Console.Write($"{M}, ");
        NumbersRange(M - 1, N);
    }
}