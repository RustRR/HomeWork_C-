// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine($"Введите размер трёхмерного массива X x Y x Z");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[x, y, z];
Console.WriteLine();
CreateArray(array);
ShowArray(array);

void CreateArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int a = 0; a < temp.GetLength(0); a++)
    {
        temp[a] = new Random().Next(10, 100);
        number = temp[a];
        if (a >= 1)
        {
            for (int b = 0; b < a; b++)
            {
                while (temp[a] == temp[b])
                {
                    temp[a] = new Random().Next(10, 100);
                    b = 0;
                    number = temp[a];
                }
                number = temp[a];
            }
        }
    }

    int count = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = temp[count];
                count += 1;
            }
        }
    }
}

void ShowArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write($"{array[a, b, c]}({a}, {b}, {c})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}