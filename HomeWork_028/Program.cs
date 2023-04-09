// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте значение N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте значение M: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(firstNumber, secondNumber);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");

int SumNumbers(int from, int to)
{
    if (from == to)
    {
        return from;
    }
    var direction = to > from ? 1 : -1;
    return SumNumbers(from + direction, to) + from;
}