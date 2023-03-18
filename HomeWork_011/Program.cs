// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b < 1)
    Console.Write("Число 2 должно быть натуральным");
else
{
    while (b != 0)
    {
        c = c * a;
        b = b - 1;
    }
    Console.Write($"Число 1 в натуральной степени числа 2 равно {c}");
}