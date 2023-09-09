// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

//исходные данные и массив, куда будем выводить результат
int[,] array = new int[4, 4];
int[,] array_result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

void FillArray(int[,] array) //метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 1000);
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

static int[,] CropArray(int[,] array) // метод для удаления
{

    //определим минимальный элемент и его положение
    int min_index_i = 0;
    int min_index_j = 0;
    int min_value = Int32.MaxValue;

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
    // Разметность нового массива будет на 1 меньше
    int rows = array.GetLength(0) - 1;
    int cols = array.GetLength(1) - 1;
    int[,] result = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        if (i < min_index_i) //если текущая строка меньше удаляемой
        {
            for (int j = 0; j < cols; j++)
            {
                if (j < min_index_j) //если текущий столбец меньше удаляемого
                {
                    result[i, j] = array[i, j];
                }
                else  //иначе сдвиг по столбцу
                {
                    result[i, j] = array[i, j + 1];
                }
            }
        }
        else //аналогично, иначе сдвиг по строке
        {
            for (int j = 0; j < cols; j++)
            {
                if (j < min_index_j)
                {
                    result[i, j] = array[i + 1, j];
                }
                else
                {
                    result[i, j] = array[i + 1, j + 1];
                }
            }
        }
    }
    return result;
}

FillArray(array);
Console.WriteLine("Задан массив");
PrintArray(array);
array_result = CropArray(array);
Console.WriteLine("Новый массив ниже");
PrintArray(array_result);

