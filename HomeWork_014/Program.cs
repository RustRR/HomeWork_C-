// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void massif(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
        Console.Write(randomArray[i] + ", ");
    }

}
int sum(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            sum = sum + 1;
    }
    return sum;
}
massif(a);
Console.Write($"\nКоличество чётных чисел в массиве: { sum(randomArray)}");