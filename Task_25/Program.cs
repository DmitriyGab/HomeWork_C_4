// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Собственное решение
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести число");
int level = Convert.ToInt32(Console.ReadLine());

int sum = num1;
for (int i=1; i<level; i++)
{
    sum=sum*num1;
    Console.WriteLine(sum);
}

Console.WriteLine($"итоговое значение {sum}");

// Решение из семинара № 3

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести число");
int level1 = Convert.ToInt32(Console.ReadLine());

double sum1 = Math.Pow(num2, level1);
Console.WriteLine("число "+num2+" в степени " + level1 + " = " +sum1);