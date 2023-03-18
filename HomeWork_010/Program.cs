// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cub(num);

void Cub(int num)
{
    Console.Write("Таблица кубов: ");
    for (int i = 1; i <= num; i++)
    {
        int A = i * i * i;
        Console.Write($"{A}, ");
    }
}