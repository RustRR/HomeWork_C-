// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
OutputNumbers(m, n);

void OutputNumbers(int m, int n)
{
    if (m <= n)
    {
        OutputNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}