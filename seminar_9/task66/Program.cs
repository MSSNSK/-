// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    if (m == n) return m;
    else if (m > n) return m + SumNumbers(--m, n);
    else return m + SumNumbers(++m, n);
}

Console.Write("Enter the initial number: ");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the final number: ");
int numFinal = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(numStart, numFinal);
Console.WriteLine($"The sum of natural numbers from {numStart} to {numFinal} equal: {result}");