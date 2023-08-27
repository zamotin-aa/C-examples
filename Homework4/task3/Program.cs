// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]


int[] array = new int[8];

// Заполняем массив случайными числами от 0 до 9
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10);
}

// Выводим массив на экран
Console.WriteLine("Массив из 8 элементов:");
foreach (int element in array)
{
    Console.Write(element + " ");
}
Console.WriteLine();