// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[3, 3];  //первая матрица
int[,] array2 = new int[3, 3];  //вторая матрица
int[,] array_result = new int[3, 3]; //матрица для результата

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array) // метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] MultiplyArray(int[,] array1, int[,] array2) //метод умножения двух массивов
{
    // !!!!!!!!!
    //по условию матрицы отдной размерности, поэтому проверку не делаю
    //проверка может выглядеть так:
    // Проверяем, что матрицы не пустые и имеют одинаковую размерность
    // if (array1 == null || array2 == null || array1.GetLength(0) == 0 || array2.GetLength(1) == 0 || 
    // array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
    // {
    //     throw new ArgumentException("Матрицы должны быть не пустыми и одинаковой размерности");
    // }
    // !!!!!!!!!

    int rows = array1.GetLength(0);
    int cols = array1.GetLength(1);
    int[,] result = new int[rows, cols]; // Создаем новый массив для хранения результата

    // Перемножаем элементы матриц по правилу умножения матриц
    for (int i = 0; i < rows; i++) // Перебираем строки первой матрицы
    {
        for (int j = 0; j < cols; j++) // Перебираем столбцы второй матрицы
        {
            int sum = 0; // Сумма произведений элементов
            for (int k = 0; k < cols; k++) // Перебираем столбцы первой и строки второй матрицы
            {
                sum += array1[i, k] * array2[k, j]; // Умножаем и складываем элементы
            }
            result[i, j] = sum; // Присваиваем результат элементу результирующей матрицы
        }
    }
    return result; // Возвращаем результат
}

FillArray(array1);
FillArray(array2);
Console.WriteLine("Заданы две матрицы:");
PrintArray(array1);
Console.WriteLine("");
PrintArray(array2);
Console.WriteLine("");
array_result = MultiplyArray(array1, array2);
Console.WriteLine("Результирующая матрица ниже:");
PrintArray(array_result);




