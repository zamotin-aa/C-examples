// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[4, 4];

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMinSumArray(int[,] array)
{// поиск минимальной суммы

    int rows = array.GetLength(0);
    int[] result = new int[rows]; // Создаем новый массив для хранения результата

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        result[i] = sum;
    }

    int minn = result[0];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        Console.Write(result[i] + " ");
        if (result[i] < minn)
        {
            count = i;
        }
    }

    Console.WriteLine("Минимальная строка это строка - " + (count));

}

FillArray(array);
Console.WriteLine();
FindMinSumArray(array);