// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
void array(int m, int n)
{
    int a, b;
    Random rand = new Random();
    for (a = 0; a < m; a++)
    {
        Console.WriteLine();
        for (b = 0; b < n; b++)
        {
            randomArray[a, b] = rand.NextDouble();
            Console.Write($"{randomArray[a, b]:F2} ");
        }
    }
}
array(m, n);