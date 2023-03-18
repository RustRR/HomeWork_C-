// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num, a, sum = 0, b;
Console.WriteLine("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
Five(num);



void Five(int num)
{
    if (num > 9999 && num < 100000)
    {
        for (b = num; num != 0; num = num / 10)
        {
            a = num % 10;
            sum = sum * 10 + a;
        }
        if (b == sum)
            Console.Write($"{b} является палиндромом");
        else
            Console.Write($"{b} не является палиндромом");
    }
    else
        Console.Write("Введите пятизначное число!  ");
}