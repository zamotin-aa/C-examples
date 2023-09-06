// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - 
// позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, 
// метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, 
// метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, 
// а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - 
// позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по 
// указанным координатам (x и y), используя результаты из метода FindNumberByPosition. 
// Если такого элемента нет, вывести на экран "There is no such index". 
// Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".




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

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] check_matrix = new int[2];
        // Проверяем, что координаты x и y находятся в пределах границ матрицы
        if (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
        {
            // Присваиваем первому элементу массива значение числа в указанной позиции
            check_matrix[0] = matrix[x, y];
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
        if (result[1] == 0)
        {
            // Выводим на экран сообщение с координатами и значением элемента
            Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
        }
        else
        {
            // Выводим на экран сообщение об ошибке
            Console.WriteLine("There is no such index");
        }

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
        n = 3;
        m = 4;
        k = 2;
        x = 2;
        y = 3;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
}
}