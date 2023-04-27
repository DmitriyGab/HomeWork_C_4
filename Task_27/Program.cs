// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (num1 > 0)
    {
        count = count + (num1 % 10);
        num1 = num1 / 10;
    }

Console.WriteLine(count);