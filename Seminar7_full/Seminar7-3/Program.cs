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

                Console.Write(matrix[i, j] + " ");
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

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        // Выводим на экран начало сообщения
        Console.WriteLine("The averages in columns are: ");
        // Проходим по всем элементам массива
        for (int i = 0; i < list.Length; i++)
        {
            // Выводим на экран текущий элемент, округленный до двух знаков после запятой, и знак табуляции
            Console.Write($"{list[i]:F2}\t");
        }
        // Выводим на экран перенос строки
        Console.WriteLine();
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        // Создаем массив для возвращаемого значения
        double[] result = new double[matrix.GetLength(1)];
        // Проходим по всем столбцам матрицы
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Объявляем переменную для суммы элементов в столбце
            int sum = 0;
            // Проходим по всем строкам матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Добавляем текущий элемент к сумме
                sum += matrix[i, j];
            }
            // Вычисляем среднее значение элементов в столбце и присваиваем его соответствующему элементу массива
            result[j] = (double)sum / matrix.GetLength(0);
        }
        // Возвращаем массив
        return result;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}