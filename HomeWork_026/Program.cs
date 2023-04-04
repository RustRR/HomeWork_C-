// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int a = 0;
int b = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[a, b] = temp;
    temp++;
    if (a <= b + 1 && a + b < sqareMatrix.GetLength(1) - 1)
        b++;
    else if (a < b && a + b >= sqareMatrix.GetLength(0) - 1)
        a++;
    else if (a >= b && a + b > sqareMatrix.GetLength(1) - 1)
        b--;
    else
        a--;
}
WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            if (array[a, b] / 10 <= 0)
                Console.Write($" {array[a, b]} ");

            else Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}