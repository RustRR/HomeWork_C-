// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void array(int m, int n)
{
    int a, b;
    Random rand = new Random();
    for (a = 0; a < m; a++)
    {
        Console.WriteLine();
        for (b = 0; b < n; b++)
        {
            randomArray[a, b] = rand.Next(1, 9);
            Console.Write($"{randomArray[a, b]} ");
        }
        Console.WriteLine();
    }
}
void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int a, b;
    Random rand = new Random();
    for (b = 0; b < n; b++)
    {
        double sum = 0;
        for (a = 0; a < m; a++)
        {
            sum = sum + randomArray[a, b];
        }
        Console.Write($"{sum / (a):F1}; ");
    }
}
array(m, n);
arif(m, n);