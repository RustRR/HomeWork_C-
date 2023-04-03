// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void sorting(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[a, c] < array[a, c + 1])
                {
                    int temp = array[a, c + 1];
                    array[a, c + 1] = array[a, c];
                    array[a, c] = temp;
                }
            }
        }
    }
}
sorting(randomArray);
Console.WriteLine("Отсортированный массив: ");
printm(randomArray);