// void PrintArray(int[,] matrix)
// {
//     // Введите свое решение ниже
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();

//     }

// }

// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     // Введите свое решение ниже
//     int[,] matrix = new int[n, m];
//     // Начальное значение элемента
//     int value = 1;
//     // Проходим по всем строкам матрицы
//     for (int i = 0; i < n; i++)
//     {
//         // Проходим по всем столбцам матрицы
//         for (int j = 0; j < m; j++)
//         {
//             // Присваиваем текущему элементу значение
//             matrix[i, j] = value;
//             // Увеличиваем значение на k
//             value += k;
//         }
//     }
//     // Возвращаем матрицу
//     return matrix;

// }


// int[] FindNumberByPosition(int[,] matrix, int x, int y)
// {
//     // Введите свое решение ниже
//     int[] check_matrix = new int[2];
//     // Проверяем, что координаты x и y находятся в пределах границ матрицы
//     if (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
//     {
//         // Присваиваем первому элементу массива значение числа в указанной позиции
//         check_matrix[0] = matrix[x, y];
//         // Присваиваем второму элементу массива 0, чтобы показать, что операция прошла успешно без ошибок
//         check_matrix[1] = 0;
//     }
//     else
//     {
//         // Присваиваем первому элементу массива 0, чтобы показать, что координаты за пределами границ массива
//         check_matrix[0] = 0;
//         // Присваиваем второму элементу массива 0, чтобы показать, что произошла ошибка
//         check_matrix[1] = 0;

//     }

//     return check_matrix;

// }


// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     // Введите свое решение ниже
//     if (results[0] != 0)
//     {
//         // Выводим на экран сообщение с координатами и значением элемента
//         Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//     }
//     else
//     {
//         // Выводим на экран сообщение об ошибке
//         Console.WriteLine("There is no such index");
//     }

// }



// int n = 3;
// int m = 4;
// int k = 2;
// int x = 2;
// int y = 3;
// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);





using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();

        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        // Начальное значение элемента
        int value = 1;
        // Проходим по всем строкам матрицы
        for (int i = 0; i < n; i++)
        {
            // Проходим по всем столбцам матрицы
            for (int j = 0; j < m; j++)
            {
                // Присваиваем текущему элементу значение
                matrix[i, j] = value;
                // Увеличиваем значение на k
                value += k;
            }
        }
        // Возвращаем матрицу
        return matrix;

    }

    public static int[] FindNumberByPosition(int[,] matrix, int x, int y)
    {
        // Введите свое решение ниже
        int[] check_matrix = new int[2];
        // Проверяем, что координаты x и y находятся в пределах границ матрицы
        if (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
        {
            // Присваиваем первому элементу массива значение числа в указанной позиции
            check_matrix[0] = matrix[x - 1, y - 1];
            // Присваиваем второму элементу массива 0, чтобы показать, что операция прошла успешно без ошибок
            check_matrix[1] = 0;
        }
        else
        {
            // Присваиваем первому элементу массива 0, чтобы показать, что координаты за пределами границ массива
            check_matrix[0] = 0;
            // Присваиваем второму элементу массива 0, чтобы показать, что произошла ошибка
            check_matrix[1] = 0;

        }

        return check_matrix;

    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results[0] != 0)
        {
            // Выводим на экран сообщение с координатами и значением элемента
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
        else
        {
            // Выводим на экран сообщение об ошибке
            Console.WriteLine("There is no such index");
        }

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
            x = 2;
            y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }

}