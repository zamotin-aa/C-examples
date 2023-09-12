// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumber(int n, int m)
{
    if (n == m) {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(n + 1, m);
}

PrintNumber(1, 5);