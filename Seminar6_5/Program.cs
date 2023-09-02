// Треугольник


// Console.WriteLine("Введите длины сторон треугольника:");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b > c && a + c > b && b + c > a)
// {
//     Console.WriteLine("Треугольник существует.");
// }
// else
// {
//     Console.WriteLine("Треугольник не существует.");
// }


// преобразование десятичного в двоичное

// Console.Write("Введите десятичное число: ");
// int decimalNumber = int.Parse(Console.ReadLine());
// string binaryString = string.Empty;
// while (decimalNumber > 0)
// {
//     int remainder = decimalNumber % 2;
//     decimalNumber /= 2;
//     binaryString = remainder.ToString() + binaryString;
// }
// Console.WriteLine($"Двоичное представление числа: {binaryString}");



// Вывод Фибоначчи

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int first = 0;
int second = 1;
if (n == 1)
{
    Console.WriteLine(0);
}
for (int i = 0; i < n - 1; i++)
{
    if (i == 0)
    {
        Console.Write(0 + " " + 1 + " ");
    }
    else
    {
        int temp = first;
        first = second;
        second += temp;
        Console.Write(second + " ");
    }
}







// Переворот массива
// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     } 
// }

// void Reverse (int[] array)
// {
//     int tmp;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         tmp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = tmp;
//     }
// }


// копирование

// // Задача 45: Напишите программу, которая будет создавать копию заданного 
// // массива с помощью поэлементного копирования.

// void FullArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10);
//     }

// }

// int[] AddArray(int[] array)
// {
//     int[] newArray = new int [array.Length];

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray [i] = array [i];
//     }
//     return newArray;
// }

// int[] array = new int[10];

// FullArray(array);
// Console.WriteLine(string.Join(" ", array));

// // int[] newArray = AddArray(array);
// Console.WriteLine(string.Join(" ", newArray));