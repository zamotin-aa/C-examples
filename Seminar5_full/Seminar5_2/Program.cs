// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

// int[] array = new int[12];
// FillArray(array);


// void FillArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         newArray[i] = array[i] * (-1);
//     }
//     System.Console.WriteLine(String.Join(" ", array));
//     System.Console.WriteLine(String.Join(" ", newArray));




// }


// Программу надо написать на C#
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.



// int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
// int[] result = new int[(int)Math.Ceiling((double)arr.Length / 2)];

// for (int i = 0; i < result.Length; i++)
// {
//     if (i == result.Length - 1 && arr.Length % 2 != 0)
//     {
//         result[i] = arr[arr.Length / 2];
//     }
//     else
//     {
//         result[i] = arr[i] * arr[arr.Length - i - 1];
//     }
// }

// Console.WriteLine("Результат:");
// for (int i = 0; i < result.Length; i++)
// {
//     Console.Write(result[i] + " ");
// }



Main(9);

void Main(int number)
{
    int[] arr = new int[number];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }

    int count = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("Задан массив " + String.Join(" ", arr));
    Console.WriteLine("Количество чётных чисел в массиве: " + count);
}
