// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array = new int[5, 5];

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 90);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SwitchRowsCols(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (rows == cols) // Проверяем, можно ли заменить строки на столбцы
    {
        int[,] result = new int[rows, cols]; // Создаем новый массив для хранения результата
        for (int i = 0; i < rows; i++) // Заменяем строки на столбцы
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = array[j, i];
            }
        }

        Console.WriteLine("Массив после замены строк на столбцы:");  // Выводим результат на экран
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        // Выводим сообщение для пользователя
        Console.WriteLine("Замена строк на столбцы невозможна, так как массив не квадратный.");
    }
}


FillArray(array);
SwitchRowsCols(array);
