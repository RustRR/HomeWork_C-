// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1 массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Такие матирицы перемножать нельзя!");
    return;
}
int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
CreateRandomArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
ShowArray(firstMatrix);

int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];
CreateRandomArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
ShowArray(secondMatrix);

int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
ShowArray(resultMatrix);

void CreateRandomArray(int[,] arr)
{
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            arr[a, b] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            Console.Write($"{arr[a, b]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int a = 0; a < resultMatr.GetLength(0); a++)
    {
        for (int b = 0; b < resultMatr.GetLength(1); b++)
        {
            int sum = 0;
            for (int c = 0; c < firstMatr.GetLength(1); c++)
            {
                sum += firstMatr[a, c] * secondMatr[c, b];
            }
            resultMatr[a, b] = sum;
        }
    }
}