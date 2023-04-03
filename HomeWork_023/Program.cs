// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void array(int m, int n)
{
    int a, b;
    Random rand = new Random();
    for (a = 0; a < m; a++)
    {
        for (b = 0; b < n; b++)
        {
            randomArray[a, b] = rand.Next(1, 9);
        }
    }
}

void printm(int[,] array)
{
    int a, b;
    for (a = 0; a < array.GetLength(0); a++)
    {
        for (b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}

array(m, n);
Console.WriteLine("Начальный массив: ");
printm(randomArray);

int SumLine(int[,] array, int a)
{
    int sum = array[a, 0];
    for (int b = 1; b < array.GetLength(1); b++)
    {
        sum += array[a, b];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int a = 1; a < randomArray.GetLength(0); a++)
{
    if (sum > SumLine(randomArray, a))
    {
        sum = SumLine(randomArray, a);
        minSum = a + 1;
    }
}
Console.WriteLine($"Номер строки c наименьшей суммой элементов: {minSum}");