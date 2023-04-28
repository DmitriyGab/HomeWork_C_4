// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// Либо пользователь вводит массив, либо рандом вводит массив


// Console.WriteLine ("Введите число 1");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 2");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 3");
// int x3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 4");
// int x4 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 5");
// int x5 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 6");
// int x6 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 7");
// int x7 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите число 8");
// int x8 = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int [8];

// // void PrintArr ()
// // {
//     arr[0] = x1;
//     arr[1] = x2;
//     arr[2] = x3;
//     arr[3] = x4;
//     arr[4] = x5;
//     arr[5] = x6;
//     arr[6] = x7;
//     arr[7] = x8;
//     Console.WriteLine(arr);
// // }
// // int x = PrintArr();
// // Console.WriteLine(x);

int[] array1 = new int [8];

// int userArr ()
// {
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine("Введите число");
        // int temp = Convert.ToInt32(Console.ReadLine());
        // array1[i] = temp;
        array1[i] = Convert.ToInt32(Console.ReadLine());
    }
//     return array1;
// }

// int printArray = userArr();
Console.WriteLine(String.Join(", ", array1));