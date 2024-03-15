// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

//  m = 2, n = 3 -> A(m,n) = 29




Console.WriteLine("Введите целое натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
Console.Write("Некорректный ввод");
return ;
}

int FunctionAck(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = FunctionAck(n, m - 1);
        }

        n = n - 1;
    }

    return m + 1;
}

Console.Write(FunctionAck(n, m));