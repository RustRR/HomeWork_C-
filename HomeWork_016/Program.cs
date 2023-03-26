// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void massif(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(0, 99);
        Console.Write(randomArray[i] + ", ");
    }
}
int diff(int[] randomArray)
{
    int min = randomArray[0];
    int max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}
massif(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {diff(randomArray)}");