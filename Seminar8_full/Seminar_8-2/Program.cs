// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] array = new int[4, 4];

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11, 99);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
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




void CropArray(int[,] array) // метод для удаления
{
    int min_index_i = 0;
    int min_index_j = 0;
    int min_value = 100000;// потом доработать. тут для примера

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min_value)
            {
                min_index_i = i;
                min_index_j = j;
                min_value = array[i, j];
            }
        }
    }

    // Создаем новый массив для хранения результата
    int rows = array.GetLength(0) - 1;
    int cols = array.GetLength(1) - 1;
    int[,] result = new int[rows, cols]; // Создаем новый массив для хранения результата

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i < min_index_i && j < min_index_j) // Если текущий индекс меньше удаляемого, то копируем элемент без изменений
            {
                result[i, j] = array[i, j];
                Console.Write(result[i, j] + " ");
            }
            // Если текущий индекс больше или равен удаляемому, то копируем элемент со сдвигом на одну строку вверх
            else
            {
                result[i, j] = array[i + 1, j + 1];
                Console.Write(result[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine("Новый массив ниже");
CropArray(array);


