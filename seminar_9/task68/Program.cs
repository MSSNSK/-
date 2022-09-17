// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 & n == 0) return AkkermanFunction(m - 1, 1);
    else if (m > 0 & n > 0)
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return 0;
}

Console.Write("Enter the number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Calculation of Ackerman's function: {AkkermanFunction(numberM, numberN)}");