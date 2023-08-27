// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowerFX(int x, int y)
{
    int sumx = 1;
    for (int i = 1; i <= y; i++)
    {
        sumx = x * sumx;
    }
    return sumx;
}

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Parse("Введите число");
int b = Parse("Введите число");

int result = PowerFX(a, b);

Console.WriteLine(result);



