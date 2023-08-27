// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Parse("Введите число");

int Sumxx(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Введено отрицательное число");
        return 0;
    }
    else
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
}

Console.WriteLine(Sumxx(number));
